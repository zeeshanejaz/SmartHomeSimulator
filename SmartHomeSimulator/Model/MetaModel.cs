using SmartHomeSimulator.Log;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SmartHomeSimulator.Model
{
    public abstract class MetaModel
    {
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public string ReadPropertyValue(string propertyName)
        {
            return readPropertyValue(this, propertyName);
        }

        public void WritePropertyValue(string propertyName, string value)
        {
            writePropertyValue(this, propertyName, value);
        }
        
        public string ExecuteMethod(string methodName, List<string> parameters)
        {
            return executeMethod(this, methodName, parameters);
        }

        protected static string readPropertyValue(object targetObject, string propertyName)
        {
            BindingFlags flags = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance;
            PropertyInfo propertyInfo = targetObject.GetType().GetProperty(propertyName, flags);
            if (propertyInfo == null)
                throw new LoggedException("The requested property does not exist in the target object.");

            if(!propertyInfo.CanRead)
                throw new LoggedException("The requested property does not support reading value.");

            return propertyInfo.GetValue(targetObject, null).ToString();
        }

        protected static void writePropertyValue(object targetObject, string propertyName, string propertyValue)
        {
            BindingFlags flags = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance;
            PropertyInfo propertyInfo = targetObject.GetType().GetProperty(propertyName, flags);
            if (propertyInfo == null)
                throw new LoggedException("The requested property does not exist in the target object.");

            if (!propertyInfo.CanWrite)
                throw new LoggedException("The requested property does not support writting value.");

            object value = castParameter(propertyValue, propertyInfo.PropertyType);

            propertyInfo.SetValue(targetObject, value, null);
        }

        protected static string executeMethod(object targetObject, string methodName, List<string> parameters)
        {
            BindingFlags flags = BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance;
            MethodInfo methodInfo = targetObject.GetType().GetMethod(methodName, flags);
            if (methodInfo == null)
                throw new LoggedException("The requested method does not exist in the target object.");

            ParameterInfo[] parametersInfo = methodInfo.GetParameters();
            if (parametersInfo.Length <= 0)            
                return methodInfo.Invoke(targetObject, null).ToString();

            List<object> paramterValues = new List<object>();

            int count = 0;
            foreach(ParameterInfo pInfo in parametersInfo)
            {
                object value = castParameter(parameters[count], pInfo.ParameterType);

                if (value == null)
                    throw new LoggedException("Unable to parse given parameters for invoking method call.");

                paramterValues.Add(value);
                count++;
            }

            object result = methodInfo.Invoke(targetObject, paramterValues.ToArray());
            return (result == null) ? string.Empty : result.ToString();
        }

        private static object castParameter(string parameter, Type pType)
        {
            object value = null;

            if (pType == typeof(int))
            {
                int tempVal;
                if (int.TryParse(parameter, out tempVal))
                    value = tempVal;
            }
            else if (pType == typeof(bool))
            {
                bool tempVal;
                if (parameter == "0")
                    value = false;

                else if (parameter == "1")
                    value = true;

                else if (bool.TryParse(parameter, out tempVal))
                    value = tempVal;
            }
            else if (pType == typeof(double))
            {
                double tempVal;
                if (double.TryParse(parameter, out tempVal))
                    value = tempVal;
            }
            else if (pType == typeof(float))
            {
                float tempVal;
                if (float.TryParse(parameter, out tempVal))
                    value = tempVal;
            }
            else if (pType == typeof(string))
            {
                value = parameter;
            }

            return value;
        }
    }
}
