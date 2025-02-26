using DataAccesslayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer
{
    internal interface IDataRepository
    {
        Task AddUser(User user);

        Task AddMemoUser(Guid UserGuid, string TitleMemo, string Text);

        Task<IEnumerable<Memo?>> GetUserMemo(Guid UserGuid);

        Task DeleteUserMemo(Guid UserGuid, int MemoId);
    }
}
