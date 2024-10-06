using System.Collections.Generic;

namespace RestApi.Repository
{
    /*  burada update , delete gibi işlemlerin geneln tabloda da yapılması için 
        generic class olusturduk ve bu class'a sadece newlenen ve class olan objeler 
        gönderilebilsin diye
    */
    public interface IGenericRepository<T> where T: class , new()
    {
        //CRUD islemler  : create , delete , update , read  

        T Add (T entity);  
        /* burada ornegin t ile gonderilen tabloya ekleme yap , ekleme yapmak içinde
         t modelinin içine eklenecek veriyi de gönder */
        T Delete (T entity);
        T GetById (int id);
        List<T> GetAll();
        T UpdateById(T entity, int id);

    }
}