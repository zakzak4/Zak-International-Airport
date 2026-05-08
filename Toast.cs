using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Zak_International_Airport
{
    internal class Toast
    {
        public void ToastMessage(string Message)
        {
            try
            {
                PopupNotifier popup = new PopupNotifier();
                //The Image
                //popup.Image = Properties.Resources.AIR;
                popup.TitleText = "Notification";
                popup.ContentText = Message;
                popup.ShowCloseButton = true;
                popup.ShowOptionsButton = true;
                popup.ShowGrip = true;
                popup.Scroll = true;
                popup.Size = new Size(300, 100);    //Width, height (pixels)
                //These next 3 put the image and the text further inside the box. (looks better)
                popup.ImagePadding = new Padding(10);
                popup.TitlePadding = new Padding(10);
                popup.ContentPadding = new Padding(0);
                //Duration of animation in ms of popup. (time to show in full).
                popup.AnimationDuration = 500;
                //Duration of how long it takes to open from button press.
                popup.AnimationInterval = 500;
                //How long it stays for.
                popup.Delay = 2000;
                //These are all style and colour
                popup.BodyColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popup.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popup.ContentFont = new System.Drawing.Font("Arial", 13F);
                popup.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popup.ContentPadding = new Padding(0);
                popup.GradientPower = 100;
                popup.HeaderHeight = 1;
                //Start the pop up toast.
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Exception [{0}] Was Caught!", ex.Message);
            }
        }
    }
}
