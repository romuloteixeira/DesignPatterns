using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities
{
    public abstract class BaseEntity<IdType> 
        where IdType : IEquatable<IdType>
    {
        public IdType Id { get; protected set; }
    }
}
