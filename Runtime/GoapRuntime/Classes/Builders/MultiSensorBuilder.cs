using System;
using Goap.Core;

namespace Goap.Runtime
{
    public class MultiSensorBuilder<T> : MultiSensorBuilder
        where T : IMultiSensor
    {
        public MultiSensorBuilder() : base(typeof(T)) { }
        
        public MultiSensorBuilder<T> SetCallback(Action<T> callback)
        {
            this.config.Callback = (obj) => callback((T) obj);
            return this;
        }
    }

    public class MultiSensorBuilder
    {
        protected readonly MultiSensorConfig config;

        public MultiSensorBuilder(Type type)
        {
            this.config = new MultiSensorConfig()
            {
                Name = type.Name,
                ClassType = type.AssemblyQualifiedName,
            };
        }

        public IMultiSensorConfig Build()
        {
            return this.config;
        }

        public static MultiSensorBuilder<TMultiSensor> Create<TMultiSensor>()
            where TMultiSensor : IMultiSensor
        {
            return new MultiSensorBuilder<TMultiSensor>();
        }
        
        public static MultiSensorBuilder Create(Type _type)
        {
            return new MultiSensorBuilder(_type);
        }
    }
}
