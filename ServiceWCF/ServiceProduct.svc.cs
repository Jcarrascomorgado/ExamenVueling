using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProduct" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProduct.svc o ServiceProduct.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProduct : IServiceProduct
    {
        IRepositoryProduct _repository;
        public ServiceProduct(IRepositoryProduct repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("Repository Product");
            }
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll().ToList();
        }
    }
}
