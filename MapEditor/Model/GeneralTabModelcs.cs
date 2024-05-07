using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor.Model
{
    internal class GeneralTabModelcs
    {

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
    }
}
