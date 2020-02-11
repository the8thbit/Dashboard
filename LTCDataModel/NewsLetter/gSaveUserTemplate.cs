﻿using LTCDataModel.PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCDataModel.NewsLetter
{
    [TableName("templates_user")]
    [PrimaryKey("LetterID", AutoIncrement = true)]
    public class gSaveUserTemplate
    {
        public int LetterID { get; set; }
        public string TemplateTitle { get; set; }
        public string TemplateSourceMarkup { get; set; }
        public string MainBodymarkup { get; set; }
        public int TypeID { get; set; }
        public int Office_Sequence { get; set; }
        public string EmbeddedNewsletter { get; set; }
       
        public string ThumbnailPath { get; set; }
        
        public bool IsParadigmNewsletter { get; set; }
        public bool IsDefault { get; set; }
        public DateTime ModificationDate { get; set; }
    }

    public class gMakeDefault
    {  
       
        public int LetterID { get; set; }
        public bool IsDefault { get; set; }
    }
     public class gSelectedIds
    {
        public int[] SelectedIds { get; set; }

    }
     public class gArticleTemplate
    {
        public int ArticleId { get; set; }
        public int TemplateId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
    public class gCopyTemplate
    {
        public int TemplateId { get; set; }
        public string Title { get; set; }
    }
}
