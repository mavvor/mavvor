//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp11
{
    using System;
    using System.Collections.Generic;
    
    public partial class requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public requests()
        {
            this.messages = new HashSet<messages>();
        }
    
        public int request_id { get; set; }
        public string client_name { get; set; }
        public string contact_info { get; set; }
        public string user_request_text { get; set; }
        public string user_requested_the_call { get; set; }
        public string processed { get; set; }
        public Nullable<int> admin_id { get; set; }
    
        public virtual admin admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<messages> messages { get; set; }
    }
}
