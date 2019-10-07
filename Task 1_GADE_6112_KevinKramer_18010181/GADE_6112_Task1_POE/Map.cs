using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GADE_6112_Task1_POE
{
    class Map
    {
        protected Random r = new Random();
        public List<MeleeUnit> MeleeUnits = new List<MeleeUnit>();
        public List<RangedUnit> RangedUnits = new List<RangedUnit>();
        int meleeAmount;
        int rangedAmount;

        public Map(int MeleeAmount, int RangedAmount)
        {
            this.meleeAmount = MeleeAmount;
            this.rangedAmount = RangedAmount;
        }
        
        // creates units for each team
        public void CreateUnits()
        {
            int randomXPos;
            int randomYPos;
            for (int i =0; i<meleeAmount; i ++)
            {
                randomXPos = r.Next(1, 20);
                randomYPos = r.Next(1, 20);
                MeleeUnit mu = new MeleeUnit("||/", "Vikings", randomXPos, randomYPos, 5, 1, 20 ,3, false);
                MeleeUnits.Add(mu);
            }
            for (int i = 0;i<rangedAmount;i++)
            {
                randomXPos = r.Next(1, 20);
                randomYPos = r.Next(1, 20);
                RangedUnit ru = new RangedUnit("|-)-", "Vikings", randomXPos, randomYPos, 3, 5, 50,2, false);
                RangedUnits.Add(ru);
            }
            for (int i = 0; i < meleeAmount; i++)
            {
                randomXPos = r.Next(1, 20);
                randomYPos = r.Next(1, 20);
                MeleeUnit mu = new MeleeUnit("||/", "Stormers", randomXPos, randomYPos, 5, 1, 20,3, false);
                MeleeUnits.Add(mu);
            }
            for (int i = 0; i < rangedAmount; i++)
            {
                randomXPos = r.Next(1, 20);
                randomYPos = r.Next(1, 20);
                RangedUnit ru = new RangedUnit("|-)-", "Stormers", randomXPos, randomYPos, 3, 5, 50,2, false);
                RangedUnits.Add(ru);
            }
        }

        //displays the units on the groupBox
        public void Display(GroupBox groupBox)
        {
            groupBox.Controls.Clear();

            foreach (MeleeUnit mu in MeleeUnits)
            {
                Label newLabel = new Label();
                newLabel.Width = 20;
                newLabel.Height = 20;
                newLabel.Location = new Point(mu.XPos * 20, mu.YPos * 20);
                newLabel.Text = mu.Symbol;
                if(mu.Team =="Vikings") { newLabel.ForeColor = Color.Green; }// assigns a colour for the  unit (team specific)
                if (mu.Team =="Stormers") { newLabel.ForeColor = Color.Blue; }// assigns a colour for the  unit (team specific)
                groupBox.Controls.Add(newLabel);
            }

            foreach(RangedUnit ru in RangedUnits)
            {
                Label newLabel = new Label();
                newLabel.Width = 20;
                newLabel.Height = 20;
                newLabel.Location = new Point(ru.XPos * 20, ru.YPos * 20);
                newLabel.Text = ru.Symbol;
                if (ru.Team == "Vikings") { newLabel.ForeColor = Color.Green; }// assigns a colour for the  unit (team specific)
                if (ru.Team == "Stormers") { newLabel.ForeColor = Color.Blue; }// assigns a colour for the  unit (team specific)
                groupBox.Controls.Add(newLabel);
            }
        }
        //updates the units positon
        public void NewPostions()
        {
            foreach(MeleeUnit mu in MeleeUnits)
            {
                mu.XPos = r.Next(1, 20);
                mu.YPos = r.Next(1, 20);
            }

            foreach (RangedUnit ru in RangedUnits)
            {
                ru.XPos = r.Next(1, 20);
                ru.YPos = r.Next(1, 20);
            }
        }
    }
}
