﻿using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Chart.Doughnut
{
    public class DoughnutSelectionChangedBehavior : Behavior<SfChart>
    {
        public static readonly BindableProperty CommandProperty = 
            BindableProperty.Create("Command", typeof(ICommand), typeof(DoughnutSelectionChangedBehavior), null);
        public static readonly BindableProperty InputConverterProperty =
            BindableProperty.Create("Converter", typeof(IValueConverter), typeof(DoughnutSelectionChangedBehavior), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public IValueConverter Converter
        {
            get { return (IValueConverter)GetValue(InputConverterProperty); }
            set { SetValue(InputConverterProperty, value); }
        }

        public SfChart AssociatedObject { get; private set; }

        protected override void OnAttachedTo(SfChart bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;

            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.SelectionChanged += OnSelectionChanged;
        }

        protected override void OnDetachingFrom(SfChart bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.BindingContextChanged -= OnBindingContextChanged;
            bindable.SelectionChanged -= OnSelectionChanged;

            AssociatedObject = null;
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        void OnSelectionChanged(object sender,ChartSelectionEventArgs e)
        {
            if (Command == null)
            {
                return;
            }

            object parameter = Converter.Convert(e, typeof(object), null, null);
            if (Command.CanExecute(parameter))
            {
                Command.Execute(parameter);
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }
    }
}
