using System;

namespace Entities
{
    public sealed class EntityConditonFunction : IEntityCondition
    {
        private readonly Func<IEntity, bool> condition;
        
        public EntityConditonFunction(Func<IEntity, bool> condition)
        {
            this.condition = condition;
        }
        
        public bool IsTrue(IEntity entity)
        {
            return this.condition.Invoke(entity);
        }
    }
}