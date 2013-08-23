using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Xml.Serialization;
using BattlePillars.XNA;
using System.IO;
using System.Runtime.Serialization;

namespace SerializationRepro
{
    public partial class SerializationReproViewController : UIViewController
    {
        public SerializationReproViewController(IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            try
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Savegame));

                using (var stream = File.OpenRead("Savegame.xml"))
                {
                    var save = serializer.ReadObject(stream) as Savegame;

                    if (save == null)
                        throw new NullReferenceException();
                }

                new UIAlertView(string.Empty, "We're good!", null, "Ok").Show();
            }
            catch (Exception exc)
            {
                new UIAlertView("Awww snap!", exc.Message, null, "Ok").Show();
            }
        }
    }
}

