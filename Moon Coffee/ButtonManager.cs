using Moon_Coffee.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Coffee
{
    class ButtonManager
    {
        public  MoonCoffeeContext dbContext = new MoonCoffeeContext();

        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        private List<Button> buttons;

        public ButtonManager(int satir, int sutun)
        {
            buttons = new List<Button>();
            CreateButtons(satir, sutun);
            UpdateButtonColorsFromDatabase();
        }

        private void CreateButtons(int satir, int sutun)
        {
            char[] sutunBasliklari = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int sayi = 0;
            for (int i = 0; i < sutun; i++)
            {

                for (int j = 0; j < satir; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.White;
                    button.Text = $"Masa {sayi + 1}";
                    sayi++;

                    button.Location = new Point(i * 128, j * 85);
                    button.Size = new System.Drawing.Size(128, 85);
                    button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    button.Left = (i * 130);
                    button.TabIndex = 2;
                    button.Name = $"btn{sutunBasliklari[j]}{i + 1}";
                    button.Click += (sender, e) => OnButtonClick(button.Text);
                    var buttonCollor = $"{sutunBasliklari[j]} {i + 1}";

                    button.Click += Button_Click;

                    var buttonText = $"{sutunBasliklari[j]} {i + 1}";

                    if (button.BackColor != Color.White)
                    {

                    }
                    buttons.Add(button);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            OnButtonClick(clickedButton.Text);
        }
        public void UpdateButtonColorsFromDatabase()
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                foreach (var button in buttons)
                {
                    string masaNumarasi = button.Text.Substring(button.Text.IndexOf(' ') + 1);

                    Masa masa = dbContext.Masa.FirstOrDefault(m => m.masaNo == masaNumarasi && m.masaDurum == true);

                    if (masa != null)
                    {
                        button.BackColor = Color.Red; 
                    }
                    else
                    {
                        button.BackColor = Color.White; 
                    }
                }
            }
        }

        public void ChangeButtonColors(Color newColor)
        {
            foreach (var button in buttons)
            {
                button.BackColor = newColor;
            }
        }
        public List<Button> GetButtons()
        {
            return buttons;
        }

        private void OnButtonClick(string buttonText)
        {
            ButtonClick?.Invoke(this, new ButtonClickEventArgs(buttonText));
        }


    }
    public class ButtonClickEventArgs : EventArgs
    {
        public string ButtonText { get; }

        public Button Button { get; }
        public ButtonClickEventArgs(string buttonText)
        {
            ButtonText = buttonText;


        }
    }
   
}

