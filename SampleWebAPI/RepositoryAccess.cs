using System;
using System.Collections.Generic;
using System.Text;
using Cassandra;

namespace SampleWebAPI
{
    public class RepositoryAccess : IRepositoryAccess
    {
        private Cluster cluster;
        private ISession session;
        
        public RepositoryAccess()
        {
            cluster = Cluster.Builder().WithCredentials("admin","admin").AddContactPoint("172.30.231.236").Build();
            session = cluster.Connect("orderdb");
        }
        public string PostOrder(Order orderobj)
        {
            try
            {
                orderobj.Id = Guid.NewGuid();
                string strCQL = "insert into orders (id, item, quantity, price) values (?,?,?,?)";
                PreparedStatement preparedStatement = session.Prepare(strCQL);
                BoundStatement boundStatement = preparedStatement.Bind(orderobj.Id, orderobj.Item, orderobj.Quantity, orderobj.Price);
                session.Execute(boundStatement);
                return "true";
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
