namespace Äventyr
{
    public partial class Form1 : Form
    { bool altA = true;
      bool altB = false;
   

        string scenA = "Ska Viktor gå hem?";
        string scenB = "Han är påväg hem nu. Ska han stanna vid pizzerian och äta?";
        string scenC = "Han stannade kvar ute.";
        string scenD = "Han stannade och käkade mat.";
        string scenE = "Han gick hem hungrig.";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = scenA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (altA == true)
            {
                altA = false;
                altB = true;
                textBox1.Text = scenB;
            }
            else if (altB == true)
            {   altB = false;
               
                textBox1.Text = scenD;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (altA == true)
            {
                altA=false;
                textBox1.Text = scenC;
            }
            else if (altB == true)
            { altB=false;
         
              textBox1.Text=scenE; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = scenA;
            altA = true;
        }
    }
}