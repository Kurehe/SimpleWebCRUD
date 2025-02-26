using DataAccesslayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer
{
    internal class DataRepository : IDataRepository
    {
        public Task AddMemoUser(Guid UserGuid, string TitleMemo, string Text)
        {
            throw new NotImplementedException();
        }

        public Task AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserMemo(Guid UserGuid, int MemoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Memo?>> GetUserMemo(Guid UserGuid)
        {
            throw new NotImplementedException();
        }
    }
}
