using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors {
	public partial class Form1 : Form {
		private Dictionary<Winner, int> winCount = new Dictionary<Winner, int>();

		public Form1() {
			InitializeComponent();
			reset();
		}

		private void btn_Rock_Click(object sender, EventArgs e) {
			play(Choice.Rock);
		}

		private void btn_Paper_Click(object sender, EventArgs e) {
			play(Choice.Paper);
		}

		private void btn_Scissors_Click(object sender, EventArgs e) {
			play(Choice.Scissors);
		}

		private void btn_Reset_Click(object sender, EventArgs e) {
			reset();
		}

		private void reset() {
			winCount.Clear();
			foreach(Winner player in Enum.GetValues(typeof(Winner))) {
				winCount.Add(player, 0);
			}

			lbl_cChoice.Text = "Computer choice: ";
			lbl_pChoice.Text = "Player choice: ";
			lbl_Winner.Text = "Winner: ";

			updateUi();
		}

		private void updateUi() {
			String winCountText = "";

			foreach (KeyValuePair<Winner, int> entry in winCount) {
				winCountText += entry.Key.ToString() + ": " + entry.Value + "\r\n";
			}

			tbx_Result.Text = winCountText;
		}

		private Winner getWinner(Choice pChoice, Choice cChoice) {
			if(pChoice == cChoice) {
				return Winner.Tie;
			}

			if (pChoice == Choice.Rock && cChoice == Choice.Paper) {
				return Winner.Computer;
			}

			if (pChoice == Choice.Paper && cChoice == Choice.Scissors) {
				return Winner.Computer;
			}

			if (pChoice == Choice.Scissors && cChoice == Choice.Rock) {
				return Winner.Computer;
			}

			return Winner.Player;
		}

		private void play(Choice pChoice) {
			Random random = new Random();
			Choice cChoice = (Choice)random.Next(Enum.GetValues(typeof(Choice)).Length);

			Winner winner = getWinner(pChoice, cChoice);

			lbl_cChoice.Text = "Computer choice: " + cChoice.ToString();
			lbl_pChoice.Text = "Player choice: " + pChoice.ToString();
			lbl_Winner.Text = "Winner: " + winner.ToString();

			int wins;
			if (winCount.TryGetValue(winner, out wins)) {
				winCount.Remove(winner);
				winCount.Add(winner, wins + 1);
			}

			updateUi();
		}
	}
}