using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Chess;

namespace Chess.BusinessLayer
{
    public static class UI_Static
    {
        public static void setSquareChessPiece(Rectangle rec, Core.TypeOfChessPiece typeOfChessPiece)
        {
            if (typeOfChessPiece == Core.TypeOfChessPiece.NaP)
            {
                rec.Fill = null;
            }
            else
            {
                string uriaddress = "pack://application:,,,/chessPieces/" + typeOfChessPiece.ToString() + ".png";
                rec.Fill = new ImageBrush
                {
                    Stretch = Stretch.Uniform,
                    ImageSource = new BitmapImage(new Uri(uriaddress, UriKind.RelativeOrAbsolute))
                };
            }
        }
        
    }
}
