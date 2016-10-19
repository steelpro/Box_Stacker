using System;
using System.Windows.Forms;

/*
 * Zachary Betters
 * CIS 209
 * October 12, 2016
 * This program will add boxes to a crate and ship them or clear them 
 */

namespace Exam2 {
    public partial class Form1 : Form {
        
        //array created to hold boxes
        PictureBox[] boxes;

        public Form1() {
            InitializeComponent();
            
            //all picture boxes added to array
            boxes = new PictureBox[] {pictureBox1, pictureBox2, pictureBox3,
            pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };     
        }   
        
        private void pbxRed_Click(object sender, EventArgs e) {

            //red box size of 1, so if first empty slot is 1 or more
            if (isRoomAvailable(1)) {
            
                //first empty slot changes to red
                boxes[FirstEmptySlot()].BackColor = System.Drawing.Color.Red;
            }
            //if there are no empty slots left
            else {
                MessageBox.Show("Cannot add anymore red boxes! Please ship or empty!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }              
        }
        private void pbxGreen_Click(object sender, EventArgs e) {
            if (isRoomAvailable(2)) {
                boxes[FirstEmptySlot()].BackColor = System.Drawing.Color.Green;
                boxes[FirstEmptySlot()].BackColor = System.Drawing.Color.Green;
            }
            else {
                MessageBox.Show("Cannot add anymore green boxes! Please ship or empty!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void pbxBlue_Click(object sender, EventArgs e) {
            if (isRoomAvailable(3)) {
                boxes[FirstEmptySlot()].BackColor = System.Drawing.Color.Blue;
                boxes[FirstEmptySlot()].BackColor = System.Drawing.Color.Blue;
                boxes[FirstEmptySlot()].BackColor = System.Drawing.Color.Blue;
            }
            else {
                MessageBox.Show("Cannot add anymore blue boxes! Please ship or empty!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }     
           
        private void btnEmpty_Click(object sender, EventArgs e) { 
            if (isEmpty()) 
                MessageBox.Show("Please fill box before emptying!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else EmptyBox();
        }
        private void btnShip_Click(object sender, EventArgs e) {
            if (isEmpty()) 
                MessageBox.Show("Please fill box before shipping!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else EmptyBox();
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }  

        public int FirstEmptySlot() {
            //i is set to 10 which is outside the number of pictureboxes 
            int i = 10;
            for (int a = 0; a < boxes.Length; a++) {
                
            //if a box has the color of wheat...              
                if (boxes[a].BackColor == System.Drawing.Color.Wheat) { 
                    //...i changes from 10 to that number box and the loop stops
                    i = a; break; }
            } 
            return i;
        } 

        public bool isRoomAvailable(int n) {
            //if the first empty slot plus the size of the..
            //...box selected does not exceed 8
            if (FirstEmptySlot() + n <= 8) return true; 
            else return false;
        }

        public bool isEmpty() {
            //if the first empty slot is less than 1, or if no boxes are added
            if (FirstEmptySlot() >= 1) return false;
            else return true;
        }
                     
        void EmptyBox() {
            for (int i = 0; i < boxes.Length; i++) {
                //each picturebox in the array is changed back to wheat when called
                boxes[i].BackColor = System.Drawing.Color.Wheat; }
        }  
    }
}