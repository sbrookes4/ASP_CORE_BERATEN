//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Data.Entity;

//namespace BeratenHealthcareDataAccessLib
//{
//    public abstract class BaseManager : IDisposable
//    {
//        internal EntityModel dbModel;

//        #region Read
//        /// <summary>
//        /// Get's database record 
//        /// </summary>
//        /// <typeparam name="T">Type of Database Entity</typeparam>
//        /// <param name="key">Primary Key of the Entity</param>
//        /// <returns></returns>
//        protected T GetEntityByKey<T>(int key) where T : class
//        {
//            return dbModel.Set<T>().Find( key );
//        }

//        protected T GetEntityByClause<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includes) where T : class
//        {
//            T entity;

//            var set = dbModel.Set<T>();
//            IQueryable<T> iq = includes.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(set, (current, inc) => current.Include(inc));
//            entity = iq.Where(predicate).FirstOrDefault();

//            return entity;
//        }

//        protected IList<T> GetEntityCollection<T>() where T : class
//        {
//            return dbModel.Set<T>().ToList();
//        }

//        protected IList<T> GetEntityCollectionByClause<T>(Func<T, bool> predicate, params Expression<Func<T, object>>[] includes) where T : class
//        {
//            IList<T> coll;
            
//            var set = dbModel.Set<T>();
//            IQueryable<T> iq = includes.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(set, (current, inc) => current.Include(inc));
//            coll = iq.Where(predicate).ToList();


//            return coll;
//        }

//        #endregion Read

//        #region Create Update Delete

//        /// <summary>
//        /// Creates a new record in the database for an entity
//        /// </summary>
//        /// <typeparam name="T">The type of Entity</typeparam>
//        /// <param name="bizObj">The instance object of the Entity</param>
//        /// <returns></returns>
//        protected T Create<T>(T bizObj) where T : class
//        {
//            dbModel.Set<T>().Add(bizObj);
//            dbModel.SaveChanges();

//            return bizObj;
//        }

//        protected bool Update<T>(T bizObj, int key)
//            where T : class
//        {
//            T entity = dbModel.Set<T>().Find(key);

//            if (entity == null)
//                return false;

//            dbModel.Entry<T>(entity).CurrentValues.SetValues(bizObj);
//            dbModel.SaveChanges();

//            return true;
//        }

//        protected bool Delete<T>( int key )
//            where T : class
//        {
//            T entity = dbModel.Set<T>().Find( key );

//            dbModel.Entry<T>( entity ).State = System.Data.Entity.EntityState.Deleted;
//            dbModel.Set<T>().Remove( entity );
//            dbModel.SaveChanges();

//            return true;
//        }

//        #endregion Create Update Delete       

//        #region IDisposable Support
//        private bool disposedValue = false; // To detect redundant calls

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposedValue)
//            {
//                if (disposing)
//                {
//                    // TODO: dispose managed state (managed objects).
//                    dbModel.Dispose();
//                }
               
//                disposedValue = true;
//            }
//        }       

//        // This code added to correctly implement the disposable pattern.
//        public void Dispose()
//        {
//            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//            Dispose(true);           
//        }

//        #endregion

//    }
// }
