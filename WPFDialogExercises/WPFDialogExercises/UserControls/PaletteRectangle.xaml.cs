using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDialogExercises.UserControls
{
    /// <summary>
    /// Interaction logic for PaletteRectangle.xaml
    /// </summary>
    public partial class PaletteRectangle : UserControl
    {
        public System.Windows.Shapes.Rectangle Rectangle { get; set; }
        public List<GridRectangle> LinkedGridRectangles { get; set; }
        public PaletteRectangle()
        {
            InitializeComponent();
            Rectangle = rectangle;
            LinkedGridRectangles = new();
        }
    }
}
