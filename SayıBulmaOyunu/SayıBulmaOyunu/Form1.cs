using System.Text;

namespace SayıBulmaOyunu
{
    public partial class Form1 : Form
    {
        #region Variables
        private int randomNumber;
        private string randomSentence;
        private int stair; // basamak
        Random random;
        public TextBox[] textBoxs = new TextBox[5];
        private int[] numberDigit;
        private string guessString;
        private int guess;

        private int counter;

        #endregion

        public Form1()
        {
            InitializeComponent();

            random = new Random();

            textBoxs[0] = textBox1;
            textBoxs[1] = textBox2;
            textBoxs[2] = textBox3;
            textBoxs[3] = textBox4;
            textBoxs[4] = textBox5;

            AdjustWhichButtonsEnable(textBoxs.Length, false);
            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        private void PlayAgain(bool didWin)
        {
            if (!didWin)
            {
                MessageBox.Show("Sayı = " + randomNumber.ToString(), "Başarısız");
            }


            panel3.Enabled = true;
            panel1.Enabled = false;
            panel2.Enabled = false;

            randomSentence = "";
            randomNumber = 0;

            foreach (TextBox tb in textBoxs)
            {
                tb.Enabled = false;
                tb.Text = null;
                tb.BackColor = Color.White;
            }

            comboBox1.Enabled = false;
            comboBox2.Enabled = true;

            label4.Text = "Kalan Hak: Tanımsız";

        }

        private void buttonCreateNumber_Click(object sender, EventArgs e)
        {

            randomSentence = "";
            stair = int.Parse(comboBox1.Text);

            if (radioButton1.Enabled)
            {
                for (int i = 0; i < stair; i++)
                {
                    int rand = random.Next(9);
                    randomSentence += rand.ToString();
                }
            }
            else if (radioButton2.Enabled)
            {
                HashSet<int> set = new HashSet<int>();

                for (int i = 0; i < stair; i++)
                {
                    int rand = random.Next(9);

                    if (!set.Contains(rand))
                    {
                        set.Add(rand);
                        randomSentence += rand.ToString();
                    }
                }
            }

            AdjustWhichButtonsEnable(stair, true);
            randomNumber = int.Parse(randomSentence);
            MessageBox.Show(randomNumber.ToString());
        }

        private void tryNumber(HashSet<int> trySet, int value)
        {
            if (trySet.Contains(value))
            {
                return;
            }

            trySet.Add(value);
            randomSentence += value.ToString();
        }

        private void AdjustWhichButtonsEnable(int value, bool condition) // which button will be enable
        {
            for (int i = 0; i < value; i++)
            {
                textBoxs[i].Enabled = condition;
            }
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            numberDigit = new int[stair];

            for (int i = 0; i < stair; i++)
            {
                if (textBoxs[i].Enabled)
                {
                    numberDigit[i] = int.Parse(textBoxs[i].Text);
                }
            }

            for (int i = stair; i >= 0; i--)
            {
                guessString += textBoxs[i].Text;
            }

            guess = int.Parse(guessString);

            IfNumerIsNotFound();
            IfNumberIsInWrongIndex();
            FindCorrectPossition();


            if (guess != randomNumber)
            {
                guessString = "";

                counter--;
                label4.Text = "Kalan Hak : " + counter.ToString();

                if (counter <= 0)
                {
                    label4.Text = "Hakkınız Kalmadı";
                    PlayAgain(false);
                }

                MessageBox.Show("Wrong!");
            }
            else
            {
                MessageBox.Show("Sayı = " + guess.ToString() + "\n" + "Tebrikler bildiniz!", "Başarılı");
                PlayAgain(true);
            }
        }

        private void FindCorrectPossition()
        {
            randomSentence = randomNumber.ToString();
            for (int i = 0; i < stair; i++)
            {
                if (guessString[i] == randomSentence[i])
                {
                    textBoxs[stair - i - 1].BackColor = Color.Blue;
                }
            }
        }

        private void IfNumberIsInWrongIndex()
        {
            randomSentence = randomNumber.ToString();
            for (int i = 0; i < stair; i++)
            {
                for (int j = 0; j < stair; j++)
                {
                    if (guessString[i] == randomSentence[j])
                    {
                        textBoxs[stair - 1 - i].BackColor = Color.Red;
                    }
                }
            }
        }

        private void IfNumerIsNotFound()
        {
            randomSentence = randomNumber.ToString();

            for (int i = 0; i < stair; i++)
            {
                for (int j = 0; j < stair; j++)
                {
                    if (guessString[i] != randomSentence[j])
                    {
                        textBoxs[stair - 1 - i].BackColor = Color.White;
                    }
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            counter = int.Parse(comboBox2.SelectedItem.ToString());
            label4.Text = "";
            label4.Text = "Kalan Hak : " + counter.ToString();
            panel3.Enabled = false;
            panel2.Enabled = true;
            panel1.Enabled = true;
        }
    }
}