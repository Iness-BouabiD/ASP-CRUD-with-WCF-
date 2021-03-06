//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class ENSATEntities : DbContext
{
    public ENSATEntities()
        : base("name=ENSATEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Eleve> Eleve { get; set; }
    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual int AddStudent(Nullable<int> iD_Eleve, string cNE, string nom, string prenom, string email, byte[] photo, string tel)
    {
        var iD_EleveParameter = iD_Eleve.HasValue ?
            new ObjectParameter("ID_Eleve", iD_Eleve) :
            new ObjectParameter("ID_Eleve", typeof(int));

        var cNEParameter = cNE != null ?
            new ObjectParameter("CNE", cNE) :
            new ObjectParameter("CNE", typeof(string));

        var nomParameter = nom != null ?
            new ObjectParameter("Nom", nom) :
            new ObjectParameter("Nom", typeof(string));

        var prenomParameter = prenom != null ?
            new ObjectParameter("Prenom", prenom) :
            new ObjectParameter("Prenom", typeof(string));

        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));

        var photoParameter = photo != null ?
            new ObjectParameter("Photo", photo) :
            new ObjectParameter("Photo", typeof(byte[]));

        var telParameter = tel != null ?
            new ObjectParameter("Tel", tel) :
            new ObjectParameter("Tel", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStudent", iD_EleveParameter, cNEParameter, nomParameter, prenomParameter, emailParameter, photoParameter, telParameter);
    }

    public virtual int DeleteStudent(Nullable<int> iD_Eleve)
    {
        var iD_EleveParameter = iD_Eleve.HasValue ?
            new ObjectParameter("ID_Eleve", iD_Eleve) :
            new ObjectParameter("ID_Eleve", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStudent", iD_EleveParameter);
    }

    public virtual ObjectResult<GetStudent_Result> GetStudent()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudent_Result>("GetStudent");
    }

    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));

        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }

    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));

        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }

    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }

    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }

    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }

    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }

    public virtual int sp_upgraddiagrams()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }
}
