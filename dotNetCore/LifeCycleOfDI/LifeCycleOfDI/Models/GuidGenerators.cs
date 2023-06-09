﻿namespace LifeCycleOfDI.Models
{
    public interface IGuidGenerator
    {
        public Guid Guid { get; set; }
    }
    public interface ISingleton : IGuidGenerator
    {

    }

    public class Singleton : ISingleton
    {
        public Guid Guid { get; set; }
        public Singleton()
        {
            Guid = Guid.NewGuid();
        }
    }

    public interface IScoped : IGuidGenerator
    {
    }

    public class Scoped : IScoped
    {
        public Guid Guid { get; set; }
        public Scoped()
        {
            Guid = Guid.NewGuid();
        }
    }

    public interface ITransient : IGuidGenerator
    {

    }

    public class Transient : ITransient
    {
        public Guid Guid { get; set; }
        public Transient()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class GuidService
    {
        public ISingleton Singleton { get; set; }
        public IScoped Scoped { get; set; }
        public ITransient Transient { get; set; }

        public GuidService(ISingleton singleton, IScoped scoped, ITransient transient)
        {
            Singleton = singleton;
            Scoped = scoped;
            Transient = transient;
        }
    }
}
