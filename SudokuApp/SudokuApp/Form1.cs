using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApp
{
    public partial class frm_Main : Form
    {
        private TextBox[,] gameArray;

        public frm_Main()
        {
            InitializeComponent();
            gameArray = new TextBox[,] {
                { cell00, cell01, cell02, cell03, cell04, cell05, cell06, cell07, cell08 },
                { cell10, cell11, cell12, cell13, cell14, cell15, cell16, cell17, cell18 },
                { cell20, cell21, cell22, cell23, cell24, cell25, cell26, cell27, cell28 },
                { cell30, cell31, cell32, cell33, cell34, cell35, cell36, cell37, cell38 },
                { cell40, cell41, cell42, cell43, cell44, cell45, cell46, cell47, cell48 },
                { cell50, cell51, cell52, cell53, cell54, cell55, cell56, cell57, cell58 },
                { cell60, cell61, cell62, cell63, cell64, cell65, cell66, cell67, cell68 },
                { cell70, cell71, cell72, cell73, cell74, cell75, cell76, cell77, cell78 },
                { cell80, cell81, cell82, cell83, cell84, cell85, cell86, cell87, cell88 }
            };

            for (int i = 0; i < gameArray.Length; i++) {
                for (int j = 0; j < gameArray.Length; j++) {
                    
                }
            }


        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        public bool CheckPuzzle(TextBox[][] gameArray) {
            return (CheckRows(gameArray) && CheckColumns(gameArray) && CheckQuadrants(gameArray));
        }

        public bool CheckRows(TextBox[][] gameArray) {
            TextBox[] cellCheckArray = new TextBox[9];

            for (int i = 0; i < cellCheckArray.Length; i++) {
                for (int j = 0; j < 9; j++) {
                    cellCheckArray[j] = gameArray[i][j];
                }
                if (cellCheckArray.Distinct().Count() != cellCheckArray.Length) {
                    return false; 
                }
            }
            return true;
        }

        public bool CheckColumns(TextBox[][] gameArray) {
            TextBox[] cellCheckArray = new TextBox[9];

            for (int i = 0; i < cellCheckArray.Length; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cellCheckArray[j] = gameArray[j][i];
                }
                if (cellCheckArray.Distinct().Count() != cellCheckArray.Length)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckQuadrants(TextBox[][] gameArray)
        {
            TextBox[] cellCheckArray = new TextBox[9];



            /*for (int i = 0; i < cellCheckArray.Length ; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cellCheckArray[i][j] = gameArray[i][j];
                }
                if (cellCheckArray.Distinct().Count() != cellCheckArray.Length)
                {
                    return false;
                } 
            }*/
            return true;
        }
    }
}
