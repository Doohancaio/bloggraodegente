using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog_teste.Models
{
    public class NoticiaModel : BaseModel
    {
        public string titulo { get; set; }

        public DateTime dataPublicacao { get; set; }

        public string resumo { get; set; }

        public string conteudo { get; set; }
    }
}