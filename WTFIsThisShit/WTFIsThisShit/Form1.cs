// Have a bunch of useless usings lmao
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WTFIsThisShit {
    /// <summary>
    /// What the fuck did you just fucking say about me, you little bitch?
    /// I'll have you know I graduated top of my class in the Navy Seals, and I've been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills.
    /// I am trained in gorilla warfare and I'm the top sniper in the entire US armed forces.
    /// You are nothing to me but just another target.
    /// I will wipe you the fuck out with precision the likes of which has never been seen before on this Earth, mark my fucking words.
    /// You think you can get away with saying that shit to me over the Internet?
    /// Think again, fucker.
    /// As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot.
    /// The storm that wipes out the pathetic little thing you call your life.
    /// You're fucking dead, kid.
    /// I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that's just with my bare hands.
    /// Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit.
    /// If only you could have known what unholy retribution your little "clever" comment was about to bring down upon you, maybe you would have held your fucking tongue.
    /// But you couldn't, you didn't, and now you're paying the price, you goddamn idiot.
    /// I will shit fury all over you and you will drown in it.
    /// You're fucking dead, kiddo.
    /// </summary>
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MessageBox.Show("this is an annoying message box, get fucked");

            // ALL HAIL THE MAGIC NUMBERS!
            for (int i = 0; i < 4; i++) {
                rtxtVariables.Text += (listOfArraysFunnyMoments[i][0] + "#" + listOfArraysFunnyMoments[i][1] + "#" + listOfArraysFunnyMoments[i][2] + "#" + listOfArraysFunnyMoments[i][3]);
            }

            // THIS IS A COMMENT
            for (int i = 0; i < 2; i++) {
                rtxtVariables.Text += (anotherListOfArraysAnyoneQuestionMark[i][0] + "#" + anotherListOfArraysAnyoneQuestionMark[i][1] + "#" + anotherListOfArraysAnyoneQuestionMark[i][2] + "#" + anotherListOfArraysAnyoneQuestionMark[i][3]);
            }
            rtxtVariables.Text += (anotherListOfArraysAnyoneQuestionMark[2][0] + "#" + anotherListOfArraysAnyoneQuestionMark[2][1] + "#" + anotherListOfArraysAnyoneQuestionMark[2][2] + "#" + anotherListOfArraysAnyoneQuestionMark[2][3] + "#" + anotherListOfArraysAnyoneQuestionMark[2][4]);
            rtxtVariables.Text += (anotherListOfArraysAnyoneQuestionMark[3][0] + "#" + anotherListOfArraysAnyoneQuestionMark[3][1] + "#" + anotherListOfArraysAnyoneQuestionMark[3][2]);
            rtxtVariables.Text += (anotherListOfArraysAnyoneQuestionMark[4][0] + "#" + anotherListOfArraysAnyoneQuestionMark[4][1] + "#" + anotherListOfArraysAnyoneQuestionMark[4][2] + "#" + anotherListOfArraysAnyoneQuestionMark[4][3]);

            rtxtVariables.Text += (justASimpleArray[0] + "#" + justASimpleArray[1] + "#" + justASimpleArray[2] + "#" + justASimpleArray[3] + "#" + justASimpleArray[4]);

            for (int i = 0; i < someRandomNumbersInAnArray.Length; i++) {
                rtxtVariables.Text += (someRandomNumbersInAnArray[i] + "#"); // HAVE SOME USELESS BRACKETS LOL
            }

            for (int i = 0; i < warNames.Length; i++) {
                rtxtVariables.Text += (warNames[i] + "#");
            }
        }

        // WHY ARE THE VARIABLES UNDERNEATH THE CODE?!?!?!?! *yes*
        public static List<int[]> listOfArraysFunnyMoments = new List<int[]> {
            new int[4] {0, 0, 0, 0},
        	new int[4] {1, 1, 1, 1},
        	new int[4] {100, 100, 100, 100},
        	new int[4] {3, 1, 3, 1}
		};

        // Arbitrary numbers anyone?
        public static List<int[]> anotherListOfArraysAnyoneQuestionMark = new List<int[]> {
            new int[4] {50, 50, 50, 100},
        	new int[4] {100, 100, 100, 200},
        	new int[5] {100, 500, 1000, 3000, 5000},
        	new int[3] {50, 100, 500},
        	new int[4] {200, 500, 300, 200}
        };

        // Oh shit, here we go again.
        public static List<List<List<List<List<List<int>>>>>> aListOfListOfListOfListOfListOfListOfListAnyone = new List<List<List<List<List<List<int>>>>>>();

        public static int[] justASimpleArray = new int[] { 2, 4, 5, 2, 2 };

        public static int[] someRandomNumbersInAnArray = new int[]
        {180, 3240, 6000, 6800, 9600, 12300, 14160, 16920, 21000, 22200, 27540, 28200, 28920,
            32580, 33660, 39660, 47760, 50640};

        // Well this happened.
        public static string[] warNames = new string[18] {
            "War of Lake Regillius", "War of Corbio", "War of Veii", "War of Allia River", "Latin War", "War of Aquilonia",
            "First Punic War", "Second Punic War", "Third Punic War", "Achaean War", "War of Alesia", "War of Zela",
            "War of Actium", "War of the Medway", "The Battle of Waiting Street", "First Persian Wars", "Second Persian Wars", "Third Persian Wars"
        };

        // Some dumb code to load to a file. After the variables. Cos why the fuck not. Oh yeah by the way, fuck functions.
        // Those shits can go fuck themselves.
        /// <summary>
        /// Also some random ass summary AFTER some normal comments.
        /// This is fine.
        /// </summary>
        // this does something. I don't know. It just. Does.
        // Also I lied to you. I will actually use a function. Because funny moments.
        // INSANE INDENTATION!!!!!111!!!!111!!1!
        void loadFromFile() {
            openDialogue.Filter = "Text|*.txt";
            DialogResult result = openDialogue.ShowDialog();
            if (result == DialogResult.OK) {
                string selectedFile = openDialogue.FileName;
                try {
                    using (StreamReader sr = File.OpenText(selectedFile)) {
                        string s = "";
                        int lineNum = 1;
                        while ((s = sr.ReadLine()) != null) {
                            string[] currentSplits = s.Split('#');
                            // Switch case because I'm feeling nice. Maybe another time you won't be so lucky...
                            switch (lineNum) {
                                case 1:
                                    for (int i = 0; i < currentSplits.Length; i++) {
                                        listOfArraysFunnyMoments[0][i] = Convert.ToInt32(currentSplits[i]);
                                        int x = 1;
                                        if (x == 1) {
                                            if (x == 1) {
                                                if (x != 1) {
                                                    for (int j = 0; j < 3; j++) {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    for (int i = 0; i < currentSplits.Length; i++) {
                                        listOfArraysFunnyMoments[1][i] = Convert.ToInt32(currentSplits[i]);
                                        int x = 1;
                                        if (x == 1) {
                                            if (x == 1) {
                                                if (x != 1) {
                                                    for (int j = 0; j < 3; j++) {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < currentSplits.Length; i++) {
                                        listOfArraysFunnyMoments[2][i] = Convert.ToInt32(currentSplits[i]);
                                        int x = 1;
                                        if (x == 1) {
                                            if (x == 1) {
                                                if (x != 1) {
                                                    for (int j = 0; j < 3; j++) {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 4:
                                    for (int i = 0; i < currentSplits.Length; i++) {
                                        listOfArraysFunnyMoments[3][i] = Convert.ToInt32(currentSplits[i]);
                                        int x = 1;
                                        if (x == 1) {
                                            if (x == 1) {
                                                if (x != 1) {
                                                    for (int j = 0; j < 3; j++) {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 5:
                                    for (int i = 0; i < currentSplits.Length; i++) {
                                        anotherListOfArraysAnyoneQuestionMark[0][i] = Convert.ToInt32(currentSplits[i]);
                                        int x = 1;
                                        if (x == 1) {
                                            if (x == 1) {
                                                if (x != 1) {
                                                    for (int j = 0; j < 3; j++) {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 6:
                                    for (int i = 0; i < currentSplits.Length; i++) {
                                        anotherListOfArraysAnyoneQuestionMark[1][i] = Convert.ToInt32(currentSplits[i]);
                                        int x = 1;
                                        if (x == 1) {
                                            if (x == 1) {
                                                if (x != 1) {
                                                    for (int j = 0; j < 3; j++) {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 7:
                                    // Imagine just doing your for loops on one line for inconsistancy against the rest of the for loop code blocks
                                    for (int i = 0; i < currentSplits.Length; i++) { anotherListOfArraysAnyoneQuestionMark[2][i] = Convert.ToInt32(currentSplits[i]); int x = 1;if (x == 1) {if (x == 1) {if (x != 1) {for (int j = 0; j < 3; j++) {continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 8:
                                    for (int i = 0; i < currentSplits.Length; i++) { anotherListOfArraysAnyoneQuestionMark[3][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                case 9:
                                    for (int i = 0; i < currentSplits.Length; i++) { anotherListOfArraysAnyoneQuestionMark[4][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                case 10:
                                    for (int i = 0; i < currentSplits.Length; i++) { justASimpleArray[i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                case 11:
                                    // Some empty cases. Because, why the fuck not. This still works.
                                    break;
                                case 12:
                                    break;
                            }
                            // No one gonna ask why we forgot to load the arbitrary numbers and old roman war names arrays from the file?
                            lineNum++;
                        }
                    }
                    rtxtVariables.Text += ("\n" + selectedFile + ".txt has been loaded.");
                } catch (Exception ex) {
                    rtxtVariables.Text += ("\n" + ex.Message);
                }
            }
        }

        void saveToFile() {
            string selectedFile = "";
            bool goAhead = false;
            
            
                // Some random fucking indented block. At least this isn't python!
                saveDialog.Filter = "Text|*.txt";
                DialogResult result = saveDialog.ShowDialog();
                if (result == DialogResult.OK) {
                    selectedFile = saveDialog.FileName;
                    goAhead = true;
                }
            
            // Nice and useless if statement.
            if (goAhead) {
                Stream cs = File.Create(selectedFile);
                using (StreamWriter sw = new StreamWriter(cs)) {
                    // ALL HAIL THE MAGIC NUMBERS!
                    for (int i = 0; i < 4; i++) {
                        sw.WriteLine(listOfArraysFunnyMoments[i][0] + "#" + listOfArraysFunnyMoments[i][1] + "#" + listOfArraysFunnyMoments[i][2] + "#" + listOfArraysFunnyMoments[i][3]);
                    }

                    // THIS IS A COMMENT
                    for (int i = 0; i < 2; i++) {
                        sw.WriteLine(anotherListOfArraysAnyoneQuestionMark[i][0] + "#" + anotherListOfArraysAnyoneQuestionMark[i][1] + "#" + anotherListOfArraysAnyoneQuestionMark[i][2] + "#" + anotherListOfArraysAnyoneQuestionMark[i][3]);
                    }
                    sw.WriteLine(anotherListOfArraysAnyoneQuestionMark[2][0] + "#" + anotherListOfArraysAnyoneQuestionMark[2][1] + "#" + anotherListOfArraysAnyoneQuestionMark[2][2] + "#" + anotherListOfArraysAnyoneQuestionMark[2][3] + "#" + anotherListOfArraysAnyoneQuestionMark[2][4]);
                    sw.WriteLine(anotherListOfArraysAnyoneQuestionMark[3][0] + "#" + anotherListOfArraysAnyoneQuestionMark[3][1] + "#" + anotherListOfArraysAnyoneQuestionMark[3][2]);
                    sw.WriteLine(anotherListOfArraysAnyoneQuestionMark[4][0] + "#" + anotherListOfArraysAnyoneQuestionMark[4][1] + "#" + anotherListOfArraysAnyoneQuestionMark[4][2] + "#" + anotherListOfArraysAnyoneQuestionMark[4][3]);

                    sw.WriteLine(justASimpleArray[0] + "#" + justASimpleArray[1] + "#" + justASimpleArray[2] + "#" + justASimpleArray[3] + "#" + justASimpleArray[4]);

                    for (int i = 0; i < someRandomNumbersInAnArray.Length; i++) {
                        sw.WriteLine(someRandomNumbersInAnArray[i] + "#"); // HAVE SOME USELESS BRACKETS LOL
                    }

                    for (int i = 0; i < warNames.Length; i++) {
                        sw.WriteLine(warNames[i] + "#");
                    }
                }
                rtxtVariables.Text += ("\n" + ": File has been saved to " + selectedFile);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            saveToFile();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            loadFromFile();
        }
    }
}
// The cursed comment outside of the namespace.