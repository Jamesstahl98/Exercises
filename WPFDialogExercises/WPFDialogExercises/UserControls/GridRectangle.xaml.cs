using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for ColorRectangle.xaml
    /// </summary>
    public partial class GridRectangle : UserControl
    {
        public Rectangle Rectangle { get; set; }
        public PaletteRectangle? LinkedPaletteRectangle { get; set; }
        public GridRectangle()
        {
            InitializeComponent();
            Rectangle = rectangle;
        }
    }
}
