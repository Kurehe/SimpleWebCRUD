using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Entites
{
    internal class Memo
    {
        /// <summary>
        /// Ид заметки
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Тема заметки
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Текст заметки
        /// </summary>
        public string TextMemo {  get; set; }
    }
}
