using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Entites
{
    internal class User
    {
        /// <summary>
        /// Уникальный Ид
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Хеш пароля
        /// </summary>
        public string PasswordHash { get; set; }
        /// <summary>
        /// Записки пользователя
        /// </summary>
        public ICollection<Memo> Memos { get; set; }
    }
}
