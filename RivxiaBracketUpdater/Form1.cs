using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RivxiaBracketUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void player2Character_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Methods that I use starts here.

        private void swapButton_Click(object sender, EventArgs e) // SWAP PLAYER INFO
        {
            String tempName = player1Name.Text;
            String tempTwitter = player1Twitter.Text;
            object tempCharacter = player1Character.SelectedItem;
            decimal tempScore = player1Score.Value;
            player1Name.Text = player2Name.Text;
            player2Name.Text = tempName;
            player1Twitter.Text = player2Twitter.Text;
            player2Twitter.Text = tempTwitter;
            player1Character.SelectedItem = player2Character.SelectedItem;
            player2Character.SelectedItem = tempCharacter;
            player1Score.Value = player2Score.Value;
            player2Score.Value = tempScore;
        }
        private void swapButton2_Click(object sender, EventArgs e) // SWAP COMMENTATOR INFO
        {
            String tempName = commentator1Name.Text;
            String tempTwitter = commentator1Twitter.Text;
            commentator1Name.Text = commentator2Name.Text;
            commentator2Name.Text = tempName;
            commentator1Twitter.Text = commentator2Twitter.Text;
            commentator2Twitter.Text = tempTwitter;
        }
        private void ws1Win_Click(object sender, EventArgs e)
        {
            wf1.Text = ws1.Text;
            lq3.Text = ws2.Text;
        }
        private void ws2Win_Click(object sender, EventArgs e)
        {
            wf1.Text = ws2.Text;
            lq3.Text = ws1.Text;
        }
        private void ws3Win_Click(object sender, EventArgs e)
        {
            wf2.Text = ws3.Text;
            lq1.Text = ws4.Text;
        }
        private void ws4Win_Click(object sender, EventArgs e)
        {
            wf2.Text = ws4.Text;
            lq1.Text = ws3.Text;
        }
        private void lro1Win_Click(object sender, EventArgs e)
        {
            lq2.Text = lro1.Text;
        }
        private void lro2Win_Click(object sender, EventArgs e)
        {
            lq2.Text = lro2.Text;
        }
        private void lro3Win_Click(object sender, EventArgs e)
        {
            lq4.Text = lro3.Text;
        }
        private void lro4Win_Click(object sender, EventArgs e)
        {
            lq4.Text = lro4.Text;
        }
        private void button9_Click(object sender, EventArgs e) // wf1 WIN
        {
            gf1.Text = wf1.Text;
            lf1.Text = wf2.Text;
        }
        private void wf2Win_Click(object sender, EventArgs e)
        {
            gf1.Text = wf2.Text;
            lf1.Text = wf1.Text;
        }
        private void lq1Win_Click(object sender, EventArgs e)
        {
            ls1.Text = lq1.Text;
        }
        private void lq2Win_Click(object sender, EventArgs e)
        {
            ls1.Text = lq2.Text;
        }
        private void lq3Win_Click(object sender, EventArgs e)
        {
            ls2.Text = lq3.Text;
        }
        private void lq4Win_Click(object sender, EventArgs e)
        {
            ls2.Text = lq4.Text;
        }
        private void ls1Win_Click(object sender, EventArgs e)
        {
            lf2.Text = ls1.Text;
        }
        private void ls2Win_Click(object sender, EventArgs e)
        {
            lf2.Text = ls2.Text;
        }
        private void lf1Win_Click(object sender, EventArgs e)
        {
            gf2.Text = lf1.Text;
        }
        private void lf2Win_Click(object sender, EventArgs e)
        {
            gf2.Text = lf2.Text;
        }
        private void gf1Win_Click(object sender, EventArgs e)
        {
            winner.Text = gf1.Text;
        }
        private void gf2Win_Click(object sender, EventArgs e)
        {
            winner.Text = gf2.Text;
        }
        private void updateButton_Click(object sender, EventArgs e) //UPDATE BUTTON
        {
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Player 1 Name.txt", player1Name.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Player 2 Name.txt", player2Name.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Player 1 Twitter.txt", player1Twitter.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Player 2 Twitter.txt", player2Twitter.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Player 1 Score.txt", player1Score.Value.ToString());
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Player 2 Score.txt", player2Score.Value.ToString());
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Set.txt", setBox.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Commentator 1 Name.txt", commentator1Name.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Commentator 2 Name.txt", commentator2Name.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Commentator 1 Twitter.txt", commentator1Twitter.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Commentator 2 Twitter.txt", commentator2Twitter.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Misc 1.txt", miscBox1.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Misc 2.txt", miscBox2.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Misc 3.txt", miscBox3.Text);
            System.IO.File.WriteAllText(".\\Scoreboard Output\\Misc 4.txt", miscBox4.Text);

            System.IO.File.WriteAllText(".\\Bracket Output\\Winners Semis 1.txt", ws1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Winners Semis 2.txt", ws2.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Winners Semis 3.txt", ws3.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Winners Semis 4.txt", ws4.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Round One 1.txt", lro1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Round One 2.txt", lro2.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Round One 3.txt", lro3.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Round One 4.txt", lro4.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Winners Finals 1.txt", wf1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Winners Finals 2.txt", wf2.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Quarters 1.txt", lq1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Quarters 2.txt", lq2.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Quarters 3.txt", lq3.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Quarters 4.txt", lq4.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Semis 1.txt", ls1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Semis 2.txt", ls2.Text); 
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Finals 1.txt", lf1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Losers Finals 2.txt", lf2.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Grand Finals 1.txt", gf1.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Grand Finals 2.txt", gf2.Text);
            System.IO.File.WriteAllText(".\\Bracket Output\\Winner.txt", winner.Text);

            switch (player1Character.SelectedItem)
            {
                case "Sanae Kochiya":
                    System.IO.File.Copy(".\\Character Images\\Sanae.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Cirno":
                    System.IO.File.Copy(".\\Character Images\\Cirno.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Hong Meiling":
                    System.IO.File.Copy(".\\Character Images\\Meiling.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Utsuho Reiuji":
                    System.IO.File.Copy(".\\Character Images\\Utsuho.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Suwako Moriya":
                    System.IO.File.Copy(".\\Character Images\\Suwako.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Reimu Hakurei":
                    System.IO.File.Copy(".\\Character Images\\Reimu.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Marisa Kirisame":
                    System.IO.File.Copy(".\\Character Images\\Marisa.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Alice Margatroid":
                    System.IO.File.Copy(".\\Character Images\\Alice.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Patchouli Knowledge":
                    System.IO.File.Copy(".\\Character Images\\Patchouli.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Sakuya Izayoi":
                    System.IO.File.Copy(".\\Character Images\\Sakuya.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Youmu Konpaku":
                    System.IO.File.Copy(".\\Character Images\\Youmu.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Remilia Scarlet":
                    System.IO.File.Copy(".\\Character Images\\Remilia.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Yuyuko Saigyouji":
                    System.IO.File.Copy(".\\Character Images\\Yuyuko.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Yukari Yakumo":
                    System.IO.File.Copy(".\\Character Images\\Yukari.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Suika Ibuki":
                    System.IO.File.Copy(".\\Character Images\\Suika.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Reisen Udongein Inaba":
                    System.IO.File.Copy(".\\Character Images\\Reisen.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Aya Shameimaru":
                    System.IO.File.Copy(".\\Character Images\\Aya.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Komachi Onozuka":
                    System.IO.File.Copy(".\\Character Images\\Komachi.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Iku Nagae":
                    System.IO.File.Copy(".\\Character Images\\Iku.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
                case "Tenshi Hinanawi":
                    System.IO.File.Copy(".\\Character Images\\Tenshi.png", ".\\Scoreboard Output\\Player 1 Character.png", true);
                    break;
            }
            switch (player2Character.SelectedItem)
            {
                case "Sanae Kochiya":
                    System.IO.File.Copy(".\\Character Images\\Sanae.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Cirno":
                    System.IO.File.Copy(".\\Character Images\\Cirno.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Hong Meiling":
                    System.IO.File.Copy(".\\Character Images\\Meiling.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Utsuho Reiuji":
                    System.IO.File.Copy(".\\Character Images\\Utsuho.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Suwako Moriya":
                    System.IO.File.Copy(".\\Character Images\\Suwako.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Reimu Hakurei":
                    System.IO.File.Copy(".\\Character Images\\Reimu.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Marisa Kirisame":
                    System.IO.File.Copy(".\\Character Images\\Marisa.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Alice Margatroid":
                    System.IO.File.Copy(".\\Character Images\\Alice.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Patchouli Knowledge":
                    System.IO.File.Copy(".\\Character Images\\Patchouli.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Sakuya Izayoi":
                    System.IO.File.Copy(".\\Character Images\\Sakuya.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Youmu Konpaku":
                    System.IO.File.Copy(".\\Character Images\\Youmu.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Remilia Scarlet":
                    System.IO.File.Copy(".\\Character Images\\Remilia.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Yuyuko Saigyouji":
                    System.IO.File.Copy(".\\Character Images\\Yuyuko.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Yukari Yakumo":
                    System.IO.File.Copy(".\\Character Images\\Yukari.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Suika Ibuki":
                    System.IO.File.Copy(".\\Character Images\\Suika.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Reisen Udongein Inaba":
                    System.IO.File.Copy(".\\Character Images\\Reisen.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Aya Shameimaru":
                    System.IO.File.Copy(".\\Character Images\\Aya.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Komachi Onozuka":
                    System.IO.File.Copy(".\\Character Images\\Komachi.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Iku Nagae":
                    System.IO.File.Copy(".\\Character Images\\Iku.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
                case "Tenshi Hinanawi":
                    System.IO.File.Copy(".\\Character Images\\Tenshi.png", ".\\Scoreboard Output\\Player 2 Character.png", true);
                    break;
            }
        }
        private void resetButton_Click(object sender, EventArgs e) //RESET BUTTON
        {
            player1Name.Text = "Player 1";
            player2Name.Text = "Player 2";
            player1Twitter.Text = "Player 1 Twitter";
            player2Twitter.Text = "Player 2 Twitter";
            player1Score.Value = 0;
            player2Score.Value = 0;
            setBox.Text = "Set";
            commentator1Name.Text = "Commentator 1 Name";
            commentator2Name.Text = "Commentator 2 Name";
            commentator1Twitter.Text = "Commentator 1 Twitter";
            commentator2Twitter.Text = "Commentator 2 Twitter";
            miscBox1.Text = "Misc Text 1";
            miscBox2.Text = "Misc Text 2";
            miscBox3.Text = "Misc Text 3";
            miscBox4.Text = "Misc Text 4";
            player1Character.Text = "Player 1 Character";
            player2Character.Text = "Player 2 Character";

            ws1.Text = "Player 1";
            ws2.Text = "Player 2";
            ws3.Text = "Player 3";
            ws4.Text = "Player 4";
            lro1.Text = "Player 5";
            lro2.Text = "Player 6";
            lro3.Text = "Player 7";
            lro4.Text = "Player 8";
            wf1.Text = "";
            wf2.Text = "";
            lq1.Text = "";
            lq2.Text = "";
            lq3.Text = "";
            lq4.Text = "";
            gf1.Text = "";
            gf2.Text = "";
            ls1.Text = "";
            ls2.Text = "";
            lf1.Text = "";
            lf2.Text = "";
            winner.Text = "";
        }


    }
}
