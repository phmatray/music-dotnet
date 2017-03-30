////using System;
////using System.ComponentModel;
////using System.Linq.Expressions;
////using System.Reflection;
////using System.Runtime.CompilerServices;
////using GalaSoft.MvvmLight;
////using MidiMinuit.Models.PropertyDescriptor;

////namespace MidiMinuit.Model.MVVM
////{
////    public abstract class ObservableObject : INotifyPropertyChanged
////    {
////        public event PropertyChangedEventHandler PropertyChanged;


////        /

////        public virtual void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
////        {
////            var handler = PropertyChanged;

////            if (handler != null)
////            {
////                var propertyName = GetPropertyName(propertyExpression);

////                if (!string.IsNullOrEmpty(propertyName))
////                {
////                    // ReSharper disable once ExplicitCallerInfoArgument
////                    RaisePropertyChanged(propertyName);
////                }
////            }
////        }

////        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
////        {
////            VerifyPropertyName(propertyName);

////            var handler = PropertyChanged;
////            if (handler != null)
////            {
////                handler(this, new PropertyChangedEventArgs(propertyName));
////            }
////        }

////        protected static string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
////        {
////            if (propertyExpression == null)
////            {
////                throw new ArgumentNullException(nameof(propertyExpression));
////            }

////            var body = propertyExpression.Body as MemberExpression;

////            if (body == null)
////            {
////                throw new ArgumentException("Invalid argument", nameof(propertyExpression));
////            }

////            var property = body.Member as PropertyInfo;

////            if (property == null)
////            {
////                throw new ArgumentException("Argument is not a property", nameof(propertyExpression));
////            }

////            return property.Name;
////        }

////        public void VerifyPropertyName(string propertyName)
////        {
////            var myType = GetType();

////            if (!string.IsNullOrEmpty(propertyName)
////                && myType.GetProperty(propertyName) == null)
////            {
////                var descriptor = this as ICustomTypeDescriptor;

////                if (descriptor != null)
////                {
////                    if (descriptor.GetProperties()
////                        .Cast<PropertyDescriptor>()
////                        .Any(property => property.Name == propertyName))
////                    {
////                        return;
////                    }
////                }
////            }
////        }
////    }

////    public abstract class ViewModel : ViewModelBase
////    {
        
////    }
////}