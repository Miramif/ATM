using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public struct LangUkr
        {
            public static string t_pin = "Введіть PIN";
            public static string t_settings = "Налаштування";
            public static string t_withdraw = "Зняти гроші";
            public static string t_transfer = "Переказ на інший рахунок";
            public static string t_balance = "Баланас рахунку";
            public static string t_exit = "Завершення роботи";
            public static string t_tomenu = "Назад до меню";
            public static string t_next = "Далі";
            public static string t_withdraw_text = "Введіть сумму для зняття кратну 50";
            public static string t_transfer1 = "Введіть номер картки та сумму переказу. Переказ доступен тільки в межах нашого банку";
            public static string t_t_card = "Номер картки:";
            public static string t_t_amount = "Сума переводу:";
            public static string t_pinb = "Ввід";
            public static string t_s_change_pin = "Змінити PIN";
            public static string t_change_pin = "Введіть старий і новий PIN";
            public static string t_t_change_pin_old = "Старий PIN:";
            public static string t_t_change_pin_new = "Новий PIN:";
        }

        public struct LangEng
        {
            public static string t_pin = "Input PIN";
            public static string t_settings = "Settings";
            public static string t_withdraw = "Withdraw money";
            public static string t_transfer = "Transfer to another account";
            public static string t_balance = "Account balance";
            public static string t_exit = "Exit";
            public static string t_tomenu = "Back to menu";
            public static string t_next = "Next";
            public static string t_withdraw_text = "Enter a withdrawal amount multiple of 50";
            public static string t_transfer1 = "Input card number and amount of transfer. The transfer is only available within our bank";
            public static string t_t_card = "Card number:";
            public static string t_t_amount = "Transfer amount:";
            public static string t_pinb = "Enter";
            public static string t_s_change_pin = "Change PIN";
            public static string t_change_pin = "Input old an new PIN";
            public static string t_t_change_pin_old = "Old PIN:";
            public static string t_t_change_pin_new = "New PIN:";
        }

        readonly Account Ac1 = new Account();
        int lang;
        string card_number;
        string sum_to_withdraw;
        int pin_tries = 0;

        public Form1()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            InitializeComponent();
            openCardDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            TabFrames1.Appearance = TabAppearance.FlatButtons; TabFrames1.ItemSize = new Size(0, 1);
            TabFrames1.SizeMode = TabSizeMode.Fixed;
        }

        private void ButtonInsertCard_Click(object sender, EventArgs e)
        {
            if (openCardDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!(openCardDialog1.SafeFileName.Length <= 19))
                {
                    card_number = openCardDialog1.SafeFileName.Substring(0, 16);
                    string status = Ac1.CheckCardVerification(card_number);
                    if (status == "BLK") MessageBox.Show("Картка заблокована, зверніться у найближче віділленя банкомату\n" +
                        "Card is blocked, contact your nearest bank branch", "Помилка|Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (status == "EXP") MessageBox.Show("Картка прострочена, зверніться у найближче віділленя банкомату\n" +
                        "Card is expired, contact your nearest bank branch", "Помилка|Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (status == "ACT")
                    {
                        string bank_type = card_number.Substring(0, 4);
                        if (bank_type == "1414") buttonSettings.Enabled = true;
                        else buttonSettings.Enabled = false;
                        TabFrames1.SelectedTab = tabLanguage;
                    }
                }
            }
        }

        private void ChangeLangButUkr_Click(object sender, EventArgs e)
        {
            lang = 1;
            labelPin.Text = LangUkr.t_pin;
            buttonBalance.Text = LangUkr.t_balance;
            buttonSettings.Text = LangUkr.t_settings;
            buttonTransfer.Text = LangUkr.t_transfer;
            buttonWithdraw.Text = LangUkr.t_withdraw;
            buttonExit.Text = LangUkr.t_exit;
            buttonExitB.Text = LangUkr.t_exit;
            buttonExitW1.Text = LangUkr.t_exit;
            buttonExitW2.Text = LangUkr.t_exit;
            buttonWithdrawNext.Text = LangUkr.t_next;
            buttonWithdrawConfirm.Text = LangUkr.t_next;
            buttonToMenuB.Text = LangUkr.t_tomenu;
            buttonToMenuW1.Text = LangUkr.t_tomenu;
            buttonToMenuW2.Text = LangUkr.t_tomenu;
            labelWithdraw1.Text = LangUkr.t_withdraw_text;
            ButtonEnterPin.Text = LangUkr.t_pinb;
            buttonToMenuT1.Text = LangUkr.t_tomenu;
            buttonExitT1.Text = LangUkr.t_exit;
            labelTransfer1.Text = LangUkr.t_transfer1;
            labelTCard.Text = LangUkr.t_t_card;
            labelTAmount.Text = LangUkr.t_t_amount;
            buttonNextT1.Text = LangUkr.t_next;
            TabFrames1.SelectedTab = tabPin;
            buttonToMenuS.Text = LangUkr.t_tomenu;
            buttonToMenuSC.Text = LangUkr.t_tomenu;
            buttonExitS.Text = LangUkr.t_exit;
            ButtonExitSC.Text = LangUkr.t_exit;
            buttonChangePin.Text = LangUkr.t_s_change_pin;
            buttonNextSC.Text = LangUkr.t_next;
            labelChangePin.Text = LangUkr.t_change_pin;
            LabelNewPin.Text = LangUkr.t_t_change_pin_new;
            labelOldPin.Text = LangUkr.t_t_change_pin_old;
        }

        private void ChangeLangButEng_Click(object sender, EventArgs e)
        {
            lang = 2;
            labelPin.Text = LangEng.t_pin;
            buttonBalance.Text = LangEng.t_balance;
            buttonSettings.Text = LangEng.t_settings;
            buttonTransfer.Text = LangEng.t_transfer;
            buttonWithdraw.Text = LangEng.t_withdraw;
            buttonExit.Text = LangEng.t_exit;
            buttonExitB.Text = LangEng.t_exit;
            buttonExitW1.Text = LangEng.t_exit;
            buttonExitW2.Text = LangEng.t_exit;
            buttonWithdrawNext.Text = LangEng.t_next;
            buttonWithdrawConfirm.Text = LangEng.t_next;
            buttonToMenuB.Text = LangEng.t_tomenu;
            buttonToMenuW1.Text = LangEng.t_tomenu;
            buttonToMenuW2.Text = LangEng.t_tomenu;
            labelWithdraw1.Text = LangEng.t_withdraw_text;
            ButtonEnterPin.Text = LangEng.t_pinb;
            buttonToMenuT1.Text = LangEng.t_tomenu;
            buttonExitT1.Text = LangEng.t_exit;
            labelTransfer1.Text = LangEng.t_transfer1;
            labelTCard.Text = LangEng.t_t_card;
            labelTAmount.Text = LangEng.t_t_amount;
            buttonNextT1.Text = LangEng.t_next;
            buttonToMenuS.Text = LangEng.t_tomenu;
            buttonToMenuSC.Text = LangEng.t_tomenu;
            buttonExitS.Text = LangEng.t_exit;
            ButtonExitSC.Text = LangEng.t_exit;
            buttonChangePin.Text = LangEng.t_s_change_pin;
            buttonNextSC.Text = LangEng.t_next;
            LabelNewPin.Text = LangEng.t_t_change_pin_new;
            labelOldPin.Text = LangEng.t_t_change_pin_old;
            labelChangePin.Text = LangEng.t_change_pin;
            TabFrames1.SelectedTab = tabPin;
        }

        private void MaskedPinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonEnterPin_Click(object sender, EventArgs e)
        {
            if (!MaskedPinTextBox.MaskCompleted)
            {
                if (lang == 1)
                {
                    MessageBox.Show("Введіть PIN ще раз.", "Некоректні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (lang == 2)
                {
                    MessageBox.Show("Enter the PIN again.", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Ac1.CheckPinVerification(card_number, MaskedPinTextBox.Text))
                {
                    pin_tries = 0;
                    TabFrames1.SelectedTab = tabMainMenu;
                }
                else
                {
                    if (pin_tries <= 1)
                    {
                        if (lang == 1)
                        {
                            MessageBox.Show("Введіть PIN ще раз.", "Неправильний PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (lang == 2)
                        {
                            MessageBox.Show("Enter the PIN again.", "Wrong PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        pin_tries++;
                    }
                    else
                    {
                        if (lang == 1)
                        {
                            MessageBox.Show("Ви тричі ввели неправильний PIN. Задля безпеки картка була заблокована." +
                                " Зверніться у найближче віділленя банкомату.", "Картка заблокована", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            if (lang == 2)
                        {
                            MessageBox.Show("You have entered the wrong PIN three times. For security reasons, " +
                                "the card was blocked. Contact your nearest ATM branch.", "Card is blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        pin_tries = 0;
                        Ac1.BlockCard(card_number);
                        TabFrames1.SelectedTab = tabWelcome;
                    }
                }
            }
            MaskedPinTextBox.Text = "";
        }

        private void ButtonBalance_Click(object sender, EventArgs e)
        {
            List<string>[] Data1 = Ac1.GetInfo(card_number);
            if (lang == 1)
            {
                labelBalance.Text = "Баланс рахунку:\n" + string.Join(",", Data1[7].ToArray()) + " ГРН";
            }
            if (lang == 2)
            {
                labelBalance.Text = "Account balance:\n" + string.Join(",", Data1[7].ToArray()) + " UAH";
            }
            TabFrames1.SelectedTab = tabBalance;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonExitB_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonToMenuB_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabMainMenu;
        }

        private void ButtonWithdrawNext_Click(object sender, EventArgs e)
        {
            if (textWithdraw.Text == "")
            {
                if (lang == 1)
                {
                    MessageBox.Show("Введіть суму ще раз.", "Невірна сума", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (lang == 2)
                {
                    MessageBox.Show("Enter the amount again.", "Incorrect amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                double sum1 = Convert.ToDouble(textWithdraw.Text);
                if (sum1 % 50 != 0)
                {
                    if (lang == 1)
                    {
                        MessageBox.Show("Сума не кратна 50. Введіть суму ще раз.",
                            "Невірна сума", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (lang == 2)
                    {
                        MessageBox.Show("The amount is not multiple of 50. Please enter the amount again.",
                            "Incorrect amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    List<string>[] Data1 = Ac1.GetInfo(card_number);
                    if (Convert.ToInt32(string.Join(",", Data1[2].ToArray())) == 1)
                    {
                        sum1 += sum1 * 0.01;
                        sum_to_withdraw = string.Format("{0:0.00}", sum1);
                        if (lang == 1)
                        {
                            labelWithdraw2.Text = "Комісія на зняття з картки нашого банка складає 1%, отже із рахунку " +
                                    "спишеться: " + sum_to_withdraw + " ГРН\n Для продовження натисніть кнопку 'Далі'";
                        }
                        else if (lang == 2)
                        {
                            labelWithdraw2.Text = "The fee for withdrawal from the card of our bank is 1%, so from account will be written of: " +
                                       sum_to_withdraw + " UAH\n Press 'Next' button to proceed";
                        }
                    }
                    else
                    {
                        sum1 += sum1 * 0.05;
                        sum_to_withdraw = sum1.ToString();
                        if (lang == 1)
                        {
                            labelWithdraw2.Text = "Комісія на зняття з картки іншого банка складає 5%, отже із рахунку " +
                                    "спишеться: " + sum_to_withdraw + " ГРН\n Для продовження натисніть кнопку 'Далі'";
                        }
                        else if (lang == 2)
                        {
                            labelWithdraw2.Text = "The fee for withdrawal from the card of another bank is 5%, so from account will be written of: " +
                                       sum_to_withdraw + " UAH\n Press 'Next' button to proceed";
                        }
                    }
                    textWithdraw.Text = "";
                    TabFrames1.SelectedTab = tabWithdraw2;
                }
            }
        }

        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWithdraw1;
        }

        private void ButtonExitW1_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonToMenuW1_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabMainMenu;
        }

        private void ButtonExitW2_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonToMenuW2_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabMainMenu;
        }

        private void TextWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonWithdrawConfirm_Click(object sender, EventArgs e)
        {
            List<string>[] Data1 = Ac1.GetInfo(card_number);
            double old_balance = Convert.ToDouble(string.Join(",", Data1[7].ToArray()));
            if (old_balance < Convert.ToDouble(sum_to_withdraw))
            {
                if (lang == 1)
                {
                    MessageBox.Show("На рахунку недостатньо коштів. Введіть іншу суму", 
                        "Недостатьно коштів на рахунку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lang == 2)
                {
                    MessageBox.Show("There is not enough money in the account. " +
                        "Enter a different amount", "Not enought money", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TabFrames1.SelectedTab = tabWithdraw1;
            }
            else
            {
                double new_balance = old_balance - Convert.ToDouble(sum_to_withdraw);
                // MessageBox.Show(string.Format("{0:0.00}", new_balance + "///" + string.Join(", ", Data1[7].ToArray())));
                Ac1.Withdraw(card_number, string.Format("{0:0.00}", new_balance), string.Join(",", Data1[7].ToArray()));
                if (lang == 1)
                {
                    MessageBox.Show("Операція пройшла успішна, заберіть ваші гроші", "Результат", MessageBoxButtons.OK);
                }
                if (lang == 2)
                {
                    MessageBox.Show("The operation was successful, take your money", "Result", MessageBoxButtons.OK);
                }
                TabFrames1.SelectedTab = tabMainMenu;
            }
        }

        private void TextTAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ButtonTransfer_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabTransfer1;
        }

        private void MaskedPinTextBox_Enter(object sender, EventArgs e)
        {
            MaskedPinTextBox.SelectionStart = 0;
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                MaskedPinTextBox.Select(0, 0);
            });
        }

        private void ButtonExitT1_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonToMenuT1_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabMainMenu;
        }

        private void ButtonNextT1_Click(object sender, EventArgs e)
        {
            if (textTAmount.Text == "" || !maskedTCardNumber.MaskCompleted)
            {
                if (lang == 1)
                {
                    MessageBox.Show("Введіть дані ще раз.", "Невірні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (lang == 2)
                {
                    MessageBox.Show("Enter the data again.", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Account Ac2 = new Account();

                List<string>[] Data2 = Ac2.GetInfo(maskedTCardNumber.Text);
                List<string>[] Data1 = Ac1.GetInfo(card_number);
                if (string.Join(",", Data2[0].ToArray()) == "")
                {
                    if (lang == 1)
                    {
                        MessageBox.Show("Користувача з таким рахунком не знайдено", "Невірні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (lang == 2)
                    {
                        MessageBox.Show("No user with this account was found.", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    double From_old_balance, From_new_balance;
                    double To_old_balance, To_new_balance;
                    From_old_balance = Convert.ToDouble(string.Join(",", Data1[7].ToArray()));
                    To_old_balance = Convert.ToDouble(string.Join(",", Data2[7].ToArray()));

                    if (From_old_balance < Convert.ToDouble(textTAmount.Text))
                    {
                        if (lang == 1)
                        {
                            MessageBox.Show("На рахунку недостатньо коштів. Введіть іншу суму",
                            "Недостатьно коштів на рахунку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (lang == 2)
                        {
                            MessageBox.Show("There is not enough money in the account. " +
                            "Enter a different amount", "Not enought money", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        textTAmount.Text = "";
                    }
                    else
                    {
                        From_new_balance = From_old_balance - Convert.ToDouble(textTAmount.Text);
                        To_new_balance = To_old_balance + Convert.ToDouble(textTAmount.Text);
                        Ac1.Withdraw(card_number, string.Format("{0:0.00}", From_new_balance), string.Format("{0:0.00}", From_old_balance));
                        Ac2.Withdraw(maskedTCardNumber.Text, string.Format("{0:0.00}", To_new_balance), string.Format("{0:0.00}", To_old_balance));
                        if (lang == 1)
                        {
                            MessageBox.Show("Операція пройшла успішна", "Результат", MessageBoxButtons.OK);
                        }
                        if (lang == 2)
                        {
                            MessageBox.Show("The operation was successful", "Result", MessageBoxButtons.OK);
                        }
                        textTAmount.Text = "";
                        maskedTCardNumber.Text = "";
                        TabFrames1.SelectedTab = tabMainMenu;
                    }

                }
                Ac2.Dispose();
            }
        }

        private void MaskedTCardNumber_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                MaskedPinTextBox.Select(0, 0);
            });
        }

        private void ButtonExitS_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonToMenuS_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabMainMenu;
        }

        private void ButtonChangePin_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabChangePin;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabSettings;
        }

        private void ButtonExitSC_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabWelcome;
        }

        private void ButtonToMenuSC_Click(object sender, EventArgs e)
        {
            TabFrames1.SelectedTab = tabMainMenu;
        }

        private void ButtonNextSC_Click(object sender, EventArgs e)
        {
            if (!maskedOldPin.MaskCompleted || !maskedNewPin.MaskCompleted)
            {
                if (lang == 1)
                {
                    MessageBox.Show("Введіть дані ще раз.", "Невірні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (lang == 2)
                {
                    MessageBox.Show("Enter the data again.", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!Ac1.CheckPinVerification(card_number, maskedOldPin.Text))
                {
                    if (pin_tries <= 2)
                    {
                        if (lang == 1)
                        {
                            MessageBox.Show("Введіть старий PIN ще раз.", "Неправильний старий PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (lang == 2)
                        {
                            MessageBox.Show("Enter the old PIN again.", "Wrong old PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        pin_tries++;
                    }
                    else
                    {
                        if (lang == 1)
                        {
                            MessageBox.Show("Ви тричі ввели неправильний PIN. Задля безпеки картка була заблокована. " +
                                "Зверніться у найближче віділленя банкомату.", "Картка заблокована", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (lang == 2)
                        {
                            MessageBox.Show("You have entered the wrong PIN three times. For security reasons, the card was blocked." +
                                " Contact your nearest ATM branch.", "Card is blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        pin_tries = 0;
                        Ac1.BlockCard(card_number);
                        TabFrames1.SelectedTab = tabWelcome;
                        maskedNewPin.Text = "";
                        maskedOldPin.Text = "";
                    }
                }
                else
                {
                    Ac1.ChangePin(card_number, maskedNewPin.Text, maskedOldPin.Text);
                    if (lang == 1)
                    {
                        MessageBox.Show("Операція пройшла успішна", "Результат", MessageBoxButtons.OK);
                    }
                    if (lang == 2)
                    {
                        MessageBox.Show("The operation was successful", "Result", MessageBoxButtons.OK);
                    }
                    maskedNewPin.Text = "";
                    maskedOldPin.Text = "";
                    TabFrames1.SelectedTab = tabMainMenu;
                }
            }
        }

        private void MaskedPinTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            MaskedPinTextBox.Text = "";
            MaskedPinTextBox.SelectionStart = 0;
        }
    }
}