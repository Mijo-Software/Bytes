using MijoSoftware.Bytes;

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bytes
{
	/// <summary>
	/// Mainform
	/// </summary>
	public partial class MainForm : Form
	{
		private readonly CultureInfo culture = CultureInfo.CreateSpecificCulture(name: "en-GB");

		private readonly NumberStyles style = NumberStyles.AllowDecimalPoint;

		/// <summary>
		/// Copy to clipboard
		/// </summary>
		/// <param name="text">text</param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(
				owner: this,
				text: StringResources.messageCopiedToClipboard,
				caption: StringResources.titleCopiedToClipboard,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		/// <summary>
		/// Check if the input string is a decimal
		/// </summary>
		/// <param name="theCharacter">character</param>
		/// <param name="theTextBox">textbox</param>
		/// <returns>true, it a decimal, else false</returns>
		private bool IsOkForDecimalTextBox(char theCharacter, TextBox theTextBox)
		{
			// Only allow control characters, digits, plus and minus signs.
			// Only allow ONE plus sign.
			// Only allow ONE minus sign.
			// Only allow the plus or minus sign as the FIRST character.
			// Only allow ONE decimal point.
			// Do NOT allow decimal point or digits BEFORE any plus or minus sign.
			if (
				!char.IsControl(c: theCharacter)
				&& !char.IsDigit(c: theCharacter)
				&& (theCharacter != '.')
				&& (theCharacter != ',')
				&& (theCharacter != '-')
				&& (theCharacter != '+')
			)
			{
				// Then it is NOT a character we want allowed in the text box.
				return false;
			}
			// Only allow one decimal point.
			if ((theCharacter == '.') || ((theCharacter == ',') && ((theTextBox.Text.IndexOf(value: '.') > -1) || (theTextBox.Text.IndexOf(value: ',') > -1))))
			{
				// Then there is already a decimal point in the text box.
				return false;
			}
			// Only allow one minus sign.
			if (theCharacter == '-' && theTextBox.Text.IndexOf(value: theCharacter) > -1)
			{
				// Then there is already a minus sign in the text box.
				return false;
			}
			// Only allow one plus sign.
			if (theCharacter == '+' && theTextBox.Text.IndexOf(value: theCharacter) > -1)
			{
				// Then there is already a plus sign in the text box.
				return false;
			}
			// Only allow one plus sign OR minus sign, but not both.
			if (((theCharacter == '-') || (theCharacter == '+')) && ((theTextBox.Text.IndexOf(value: '-') > -1) || (theTextBox.Text.IndexOf(value: '+') > -1)
				)
			)
			{
				// Then the user is trying to enter a plus or minus sign and
				// there is ALREADY a plus or minus sign in the text box.
				return false;
			}
			// Only allow a minus or plus sign at the first character position.
			if (((theCharacter == '-') || (theCharacter == '+')) && theTextBox.SelectionStart != 0)
			{
				// Then the user is trying to enter a minus or plus sign at some position 
				// OTHER than the first character position in the text box.
				return false;
			}

			// Only allow digits and decimal point AFTER any existing plus or minus sign
			if (
				(
					// Is digit or decimal point
					char.IsDigit(theCharacter) || (theCharacter == '.')
				)
				&&
				(
					// A plus or minus sign EXISTS
					(theTextBox.Text.IndexOf(value: '-') > -1) || (theTextBox.Text.IndexOf(value: '+') > -1)
				)
				&&
				// Attempting to put the character at the beginning of the field.
				theTextBox.SelectionStart == 0
			)
			{
				// Then the user is trying to enter a digit or decimal point in front of a minus or plus sign.
				return false;
			}

			// Only allow digits and decimal point AFTER any existing plus or minus sign
			if (
				(
					// Is digit or decimal point
					char.IsDigit(c: theCharacter) || (theCharacter == ',')
				)
				&&
				(
					// A plus or minus sign EXISTS
					(theTextBox.Text.IndexOf(value: '-') > -1) || (theTextBox.Text.IndexOf(value: '+') > -1)
				)
				&&
				// Attempting to put the character at the beginning of the field.
				theTextBox.SelectionStart == 0
			)
			{
				// Then the user is trying to enter a digit or decimal point in front of a minus or plus sign.
				return false;
			}
			// Otherwise the character is perfectly fine for a decimal value and the character
			// may indeed be placed at the current insertion position.
			return true;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm() => InitializeComponent();

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">event arguments</param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			TextBoxBit_TextChanged(sender: default, e: EventArgs.Empty);
			checkBoxEnableBit.Checked = true;
			CheckBoxEnableBit_CheckedChanged(sender: default, e: EventArgs.Empty);
			checkBoxEnableByte.Checked = true;
			CheckBoxEnableByte_CheckedChanged(sender: default, e: EventArgs.Empty);
			checkBoxEnableKilobyte.Checked = true;
			CheckBoxEnableKilobyte_CheckedChanged(sender: default, e: EventArgs.Empty);
			checkBoxEnableMegabyte.Checked = true;
			CheckBoxEnableMegabyte_CheckedChanged(sender: default, e: EventArgs.Empty);
			checkBoxEnableGigabyte.Checked = false;
			CheckBoxEnableGigabyte_CheckedChanged(sender: default, e: EventArgs.Empty);
			checkBoxEnableTerabyte.Checked = false;
			CheckBoxEnableTerabyte_CheckedChanged(sender: default, e: EventArgs.Empty);
		}

		private void GroupBoxBit_Enter(object sender, EventArgs e) => groupBoxBit.BackColor = SystemColors.ControlLight;

		private void GroupBoxBit_Leave(object sender, EventArgs e) => groupBoxBit.BackColor = SystemColors.Control;

		private void GroupBoxByte_Enter(object sender, EventArgs e) => groupBoxByte.BackColor = SystemColors.ControlLight;

		private void GroupBoxByte_Leave(object sender, EventArgs e) => groupBoxByte.BackColor = SystemColors.Control;

		private void GroupBoxKilobyte_Enter(object sender, EventArgs e) => groupBoxKilobyte.BackColor = SystemColors.ControlLight;

		private void GroupBoxKilobyte_Leave(object sender, EventArgs e) => groupBoxKilobyte.BackColor = SystemColors.Control;

		private void GroupBoxMegabyte_Enter(object sender, EventArgs e) => groupBoxMegabyte.BackColor = SystemColors.ControlLight;

		private void GroupBoxMegabyte_Leave(object sender, EventArgs e) => groupBoxMegabyte.BackColor = SystemColors.Control;

		private void GroupBoxGigabyte_Enter(object sender, EventArgs e) => groupBoxGigabyte.BackColor = SystemColors.ControlLight;

		private void GroupBoxGigabyte_Leave(object sender, EventArgs e) => groupBoxGigabyte.BackColor = SystemColors.Control;

		private void GroupBoxTerabyte_Enter(object sender, EventArgs e) => groupBoxTerabyte.BackColor = SystemColors.ControlLight;

		private void GroupBoxTerabyte_Leave(object sender, EventArgs e) => groupBoxTerabyte.BackColor = SystemColors.Control;

		private void TextBoxBit_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOkForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textBoxBit);

		private void TextBoxByte_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOkForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textBoxByte);

		private void TextBoxKilobyte_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOkForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textBoxKilobyte);

		private void TextBoxMegabyte_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOkForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textBoxMegabyte);

		private void TextBoxGigabyte_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOkForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textBoxGigabyte);

		private void TextBoxTerabyte_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !IsOkForDecimalTextBox(theCharacter: e.KeyChar, theTextBox: textBoxTerabyte);

		private void TextBoxBit_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textBoxBit.Text.Replace(oldValue: ",", newValue: "."), style: style, provider: culture, result: out double value);
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Text = value.ToString(provider: culture);
			}
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Text = ByteUnits.BitToByte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Text = ByteUnits.BitToKilobyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableMegabyte.Checked)
			{
				textBoxMegabyte.Text = ByteUnits.BitToMegabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableGigabyte.Checked)
			{
				textBoxGigabyte.Text = ByteUnits.BitToGigabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableTerabyte.Checked)
			{
				textBoxTerabyte.Text = ByteUnits.BitToTerabyte(value: value).ToString(provider: culture);
			}
		}

		private void TextBoxByte_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textBoxByte.Text.Replace(oldValue: ",", newValue: "."), style: style, provider: culture, result: out double value);
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Text = value.ToString(provider: culture);
			}
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Text = ByteUnits.ByteToBit(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Text = ByteUnits.ByteToKilobyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableMegabyte.Checked)
			{
				textBoxMegabyte.Text = ByteUnits.ByteToMegabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableGigabyte.Checked)
			{
				textBoxGigabyte.Text = ByteUnits.ByteToGigabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableTerabyte.Checked)
			{
				textBoxTerabyte.Text = ByteUnits.ByteToTerabyte(value: value).ToString(provider: culture);
			}
		}

		private void TextBoxKilobyte_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textBoxKilobyte.Text.Replace(oldValue: ",", newValue: "."), style: style, provider: culture, result: out double value);
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Text = value.ToString(provider: culture);
			}
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Text = ByteUnits.KilobyteToBit(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Text = ByteUnits.KilobyteToByte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableMegabyte.Checked)
			{
				textBoxMegabyte.Text = ByteUnits.KilobyteToMegabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableGigabyte.Checked)
			{
				textBoxGigabyte.Text = ByteUnits.KilobyteToGigabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableTerabyte.Checked)
			{
				textBoxTerabyte.Text = ByteUnits.KilobyteToTerabyte(value: value).ToString(provider: culture);
			}
		}

		private void TextBoxMegabyte_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textBoxMegabyte.Text.Replace(oldValue: ",", newValue: "."), style: style, provider: culture, result: out double value);
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Text = ByteUnits.MegabyteToBit(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Text = ByteUnits.MegabyteToByte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Text = ByteUnits.MegabyteToKilobyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableGigabyte.Checked)
			{
				textBoxGigabyte.Text = ByteUnits.MegabyteToGigabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableTerabyte.Checked)
			{
				textBoxTerabyte.Text = ByteUnits.MegabyteToTerabyte(value: value).ToString(provider: culture);
			}
		}

		private void TextBoxGigabyte_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textBoxGigabyte.Text.Replace(oldValue: ",", newValue: "."), style: style, provider: culture, result: out double value);
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Text = ByteUnits.GigabyteToBit(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Text = ByteUnits.GigabyteToByte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Text = ByteUnits.GigabyteToKilobyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableMegabyte.Checked)
			{
				textBoxMegabyte.Text = ByteUnits.GigabyteToMegabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableTerabyte.Checked)
			{
				textBoxTerabyte.Text = ByteUnits.GigabyteToTerabyte(value: value).ToString(provider: culture);
			}
		}

		private void TextBoxTerabyte_TextChanged(object sender, EventArgs e)
		{
			double.TryParse(s: textBoxTerabyte.Text.Replace(oldValue: ",", newValue: "."), style: style, provider: culture, result: out double value);
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Text = ByteUnits.TerabyteToBit(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Text = ByteUnits.TerabyteToByte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Text = ByteUnits.TerabyteToKilobyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableMegabyte.Checked)
			{
				textBoxMegabyte.Text = ByteUnits.TerabyteToMegabyte(value: value).ToString(provider: culture);
			}
			if (checkBoxEnableGigabyte.Checked)
			{
				textBoxGigabyte.Text = ByteUnits.TerabyteToGigabyte(value: value).ToString(provider: culture);
			}
		}

		private void ButtonCopyBitToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonCopyBitToClipboard.Text);

		private void ButtonCopyByteToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonCopyByteToClipboard.Text);

		private void ButtonCopyKilobyteToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonCopyKilobyteToClipboard.Text);

		private void ButtonCopyMegabyteToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonCopyMegabyteToClipboard.Text);

		private void ButtonCopyGigabyteToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonCopyGigabyteToClipboard.Text);

		private void ButtonCopyTerabyteToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: buttonCopyTerabyteToClipboard.Text);

		private void CheckBoxEnableBit_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableBit.Checked)
			{
				textBoxBit.Enabled = true;
				buttonCopyBitToClipboard.Enabled = true;
			}
			else
			{
				textBoxBit.Enabled = false;
				buttonCopyBitToClipboard.Enabled = false;
			}
		}

		private void CheckBoxEnableByte_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableByte.Checked)
			{
				textBoxByte.Enabled = true;
				buttonCopyByteToClipboard.Enabled = true;
			}
			else
			{
				textBoxByte.Enabled = false;
				buttonCopyByteToClipboard.Enabled = false;
			}
		}

		private void CheckBoxEnableKilobyte_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableKilobyte.Checked)
			{
				textBoxKilobyte.Enabled = true;
				buttonCopyKilobyteToClipboard.Enabled = true;
			}
			else
			{
				textBoxKilobyte.Enabled = false;
				buttonCopyKilobyteToClipboard.Enabled = false;
			}
		}

		private void CheckBoxEnableMegabyte_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableMegabyte.Checked)
			{
				textBoxMegabyte.Enabled = true;
				buttonCopyMegabyteToClipboard.Enabled = true;
			}
			else
			{
				textBoxMegabyte.Enabled = false;
				buttonCopyMegabyteToClipboard.Enabled = false;
			}
		}

		private void CheckBoxEnableGigabyte_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableGigabyte.Checked)
			{
				textBoxGigabyte.Enabled = true;
				buttonCopyGigabyteToClipboard.Enabled = true;
			}
			else
			{
				textBoxGigabyte.Enabled = false;
				buttonCopyGigabyteToClipboard.Enabled = false;
			}
		}

		private void CheckBoxEnableTerabyte_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableTerabyte.Checked)
			{
				textBoxTerabyte.Enabled = true;
				buttonCopyTerabyteToClipboard.Enabled = true;
			}
			else
			{
				textBoxTerabyte.Enabled = false;
				buttonCopyTerabyteToClipboard.Enabled = false;
			}
		}
	}
}