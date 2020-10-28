# DoubleA.EntityModel

This library provides a very simple entity structure that can be used with an ORM like EntityFramework.

### Interfaces
- #### IKeyedEntity
  Represents an entity with a unique key
- #### IArchivableEntity
  Represents an entity that is archivable (and usually not deletable)

### Abstract Implementations
- #### KeyedEntity
  Provides a very simple abstract implementation of **_IKeyedEntity_**
