﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    public class RenderTransformManager : DependencyObject
    {
        public static double GetAngle(DependencyObject obj)
        {
            return (double)obj.GetValue(AngleProperty);
        }
        public static void SetAngle(DependencyObject obj, double value)
        {
            obj.SetValue(AngleProperty, value);
        }

        public static readonly DependencyProperty AngleProperty = DependencyProperty.RegisterAttached("Angle",
        typeof(double), typeof(RenderTransformManager), new UIPropertyMetadata(0.0, OnAngleChanged));

        private static void OnAngleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {            
            var element = obj as UIElement;
            if (element != null)
            {
                element.RenderTransformOrigin = new Point(.5, .5);
                element.RenderTransform = new RotateTransform((double)e.NewValue);
            }

        }




        



    }
}
