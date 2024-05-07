using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace MapEditor.Model
{
    public class MapEditorModel
    {
        double centerX = 0;
        double centerY = 0;
        double radiusX = 0;
        double radiusY = 0;
        private bool formLoaded = false;
        private bool isGridResize = false;
        private string activeDieColor = Brushes.Gray.ToString();
        private string inactiveDieColor = Brushes.Gray.ToString();
        private string borderColor = Brushes.Gray.ToString();
        private SolidColorBrush markerColor = Brushes.Ivory;
        private HashSet<string> binDefinitions = new HashSet<string>();
        private HashSet<string> binCodes = new HashSet<string>();
        private HashSet<string> binColors = new HashSet<string>();
        private string configFile = "bincode.config";

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        internal void CreateCirclesWithNotch(long gridHeight, long gridWidth)
        {
            //dynamicGrid.RowDefinitions.Clear();
            //dynamicGrid.ColumnDefinitions.Clear();
            //dynamicGrid.Children.Clear();

            //for (int i = 0; i < gridHeight; i++)
            //{
            //    dynamicGrid.RowDefinitions.Add(new RowDefinition());
            //}

            //for (int j = 0; j < gridWidth; j++)
            //{
            //    dynamicGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //}

            //centerX = gridWidth / 2.0;
            //centerY = gridHeight / 2.0;
            //radiusX = gridWidth / 2.0;
            //radiusY = gridHeight / 2.0;

            //double innercenterX = gridWidth / 2.0;
            //double innercenterY = gridHeight / 2.0;
            //double innnerradiusX = Math.Max(1, (gridWidth - 2) / 2.0);
            //double innerradiusY = Math.Max(1, (gridHeight - 2) / 2.0);

            //for (int i = 0; i < gridHeight; i++)
            //{
            //    for (int j = 0; j < gridWidth; j++)
            //    {

            //        var gridItem = new Border
            //        {
            //            BorderBrush = Brushes.Black,
            //            BorderThickness = new Thickness(1),
            //            Margin = new Thickness(1),
            //            Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(inactiveDieColor))
            //        };
            //        int centerRow = (int)Math.Round(centerY);
            //        int centerColumn = (int)Math.Round(centerX);

            //        if (IsCenterCell(j, i, centerRow, centerColumn))
            //        {
            //            gridItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(activeDieColor));
            //        }
            //        else
            //        {
            //            bool drawEllipseOnGrid = IsInEllipse(j, i, centerX, centerY, radiusX, radiusY);
            //            bool drawSmallerEllipseOnGrid = IsInEllipse(j, i, innercenterX, innercenterY, innnerradiusX, innerradiusY);

            //            if (drawEllipseOnGrid)
            //            {
            //                gridItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(borderColor));
            //            }
            //            if (drawSmallerEllipseOnGrid)
            //            {
            //                gridItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(activeDieColor));
            //            }
            //        }

            //        gridItem.MouseLeftButtonDown += GridItem_MouseLeftButtonDown;
            //        gridItem.MouseEnter += GridItem_MouseEnter;
            //        gridItem.MouseLeftButtonUp += GridItem_MouseLeftButtonUp;

            //        Grid.SetRow(gridItem, i);
            //        Grid.SetColumn(gridItem, j);
            //        dynamicGrid.Children.Add(gridItem);
            //    }
            //}

            //AddEmptyRowAndColumn();
            //GridBlueEllipseWithRedDot(centerX, centerY, radiusX, radiusY);
            //AddReferenceDie(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text), true);

            //dynamicGrid.MouseRightButtonDown += DynamicGrid_MouseRightButtonDown;
            //dynamicGrid.MouseRightButtonUp += DynamicGrid_MouseRightButtonUp;
            //dynamicGrid.MouseMove += DynamicGrid_MouseMove;


        }
        private void AddReferenceDie(int row, int column, bool isVisible)
        {

            //UIElement cell = dynamicGrid.Children
            //    .Cast<UIElement>()
            //    .FirstOrDefault(e => Grid.GetRow(e) == row && Grid.GetColumn(e) == column);
            //if (cell != null && cell is Border border && border.Child is TextBlock previousTextBlock)
            //{
            //    border.Child = null;
            //}

            //if (cell != null)
            //{
            //    TextBlock xMark = new TextBlock
            //    {
            //        Text = "X",
            //        Foreground = markerColor,
            //        FontWeight = FontWeights.Bold,
            //        FontSize = (cell as Border).ActualHeight != 0 && (cell as Border).ActualHeight <= 15 ? (cell as Border).ActualHeight : 15,
            //        HorizontalAlignment = HorizontalAlignment.Center,
            //        VerticalAlignment = VerticalAlignment.Center,
            //        Visibility = isVisible ? Visibility.Visible : Visibility.Collapsed
            //    };
            //    cell.SetValue(Grid.RowProperty, row);
            //    cell.SetValue(Grid.ColumnProperty, column);
            //    Grid.SetColumnSpan(xMark, 1);
            //    Grid.SetRowSpan(xMark, 1);
            //    (cell as Border).Child = xMark;
            //}
        }
        private void GridBlueEllipseWithRedDot(double centerX, double centerY, double radiusX, double radiusY)
        {

            //double totalGridWidth = dynamicGrid.ActualWidth;
            //double totalGridHeight = dynamicGrid.ActualHeight;
            //int numberOfrows = dynamicGrid.RowDefinitions.Count;
            //int numberOfColumns = dynamicGrid.ColumnDefinitions.Count;
            //double cellWidth = totalGridWidth / numberOfColumns;
            //double cellHeight = totalGridHeight / numberOfrows;

            //int minY = int.MaxValue;
            //int maxY = int.MinValue;
            //int minX = int.MaxValue;
            //int maxX = int.MinValue;
            //for (int i = 0; i < gridHeight; i++)
            //{
            //    for (int j = 0; j < gridWidth; j++)
            //    {
            //        if (IsInEllipse(j, i, centerX, centerY, radiusX, radiusY))
            //        {
            //            minY = Math.Min(minY, i);
            //            maxY = Math.Max(maxY, i);
            //            minX = Math.Min(minX, j);
            //            maxX = Math.Max(maxX, j);
            //        }
            //    }
            //}
            //int blueEllipseWidth = maxX - minX + 1;
            //int blueEllipseHeight = maxY - minY + 1;


            //Canvas canvas = new Canvas
            //{
            //    Width = totalGridWidth,
            //    Height = totalGridHeight,
            //    Background = Brushes.Transparent,
            //    IsHitTestVisible = false
            //};
            //Ellipse blueEllipse = new Ellipse
            //{
            //    Width = blueEllipseWidth * cellWidth,
            //    Height = blueEllipseHeight * cellHeight,
            //    Fill = Brushes.Transparent,
            //    Stroke = Brushes.DarkBlue,
            //    StrokeThickness = 3,
            //    //Visibility = Visibility.Hidden,
            //    IsHitTestVisible = false
            //};
            //Canvas.SetLeft(blueEllipse, minX * cellWidth);
            //Canvas.SetTop(blueEllipse, minY * cellHeight);
            //canvas.Children.Add(blueEllipse);

            //double actualBlueEllipseWidth = blueEllipse.Width;
            //double actualBlueEllipseHeight = blueEllipse.Height;
            //double actualCenterX = Canvas.GetLeft(blueEllipse) + actualBlueEllipseWidth / 2;
            //double actualCenterY = Canvas.GetTop(blueEllipse) + actualBlueEllipseHeight / 2;

            //double actualRadiusX = actualBlueEllipseWidth / 2;
            //double actualRadiusY = actualBlueEllipseHeight / 2;

            //if (!string.IsNullOrEmpty(txtNochRotation.Text))
            //{
            //    int degree = Math.Clamp(Convert.ToInt16(txtNochRotation.Text) + 90, 90, 449);

            //    double angleForRedDotRadius = (degree) * Math.PI / 180;
            //    double angleForRedDot_degrees = angleForRedDotRadius * (180 / Math.PI);

            //    double dotX = actualCenterX + actualRadiusX * Math.Cos(angleForRedDotRadius);
            //    double dotY = actualCenterY + actualRadiusY * Math.Sin(angleForRedDotRadius);

            //    Ellipse redDot = new Ellipse
            //    {
            //        Width = 15,
            //        Height = 15,
            //        Fill = Brushes.Red,
            //        IsHitTestVisible = false
            //    };
            //    double redDotLeft = dotX - (redDot.Width / 2);
            //    double redDotTop = dotY - (redDot.Height / 2);

            //    Canvas.SetLeft(redDot, redDotLeft);
            //    Canvas.SetTop(redDot, redDotTop);
            //    canvas.Children.Add(redDot);
            //}
            //dynamicGrid.Children.Add(canvas);
        }
        private void AddEmptyRowAndColumn()
        {
            //dynamicGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            //dynamicGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //int newRow = dynamicGrid.RowDefinitions.Count - 1;
            //int newColumn = dynamicGrid.ColumnDefinitions.Count - 1;

            //for (int i = 0; i < dynamicGrid.ColumnDefinitions.Count; i++)
            //{
            //    var emptyCell = CreateEmptyCell();
            //    emptyCell.MouseLeftButtonDown += GridItem_MouseLeftButtonDown;
            //    emptyCell.MouseEnter += GridItem_MouseEnter;
            //    emptyCell.MouseLeftButtonUp += GridItem_MouseLeftButtonUp;
            //    Grid.SetRow(emptyCell, newRow);
            //    Grid.SetColumn(emptyCell, i);
            //    dynamicGrid.Children.Add(emptyCell);
            //}

            //for (int i = 0; i < dynamicGrid.RowDefinitions.Count - 1; i++)
            //{
            //    var emptyCell = CreateEmptyCell();
            //    emptyCell.MouseLeftButtonDown += GridItem_MouseLeftButtonDown;
            //    emptyCell.MouseEnter += GridItem_MouseEnter;
            //    emptyCell.MouseLeftButtonUp += GridItem_MouseLeftButtonUp;
            //    Grid.SetRow(emptyCell, i);
            //    Grid.SetColumn(emptyCell, newColumn);
            //    dynamicGrid.Children.Add(emptyCell);
            //}
        }
        private bool IsCenterCell(int column, int row, int centerRow, int centerColumn)
        {
            return column == centerColumn && row == centerRow;
        }
        private bool IsInEllipse(double x, double y, double centerX, double centerY, double radiusX, double radiusY)
        {
            return ((x - centerX) * (x - centerX) / (radiusX * radiusX) + (y - centerY) * (y - centerY) / (radiusY * radiusY)) < 1;
        }
    }
}
