using System.Configuration;
using System.Net;

namespace Unity.SolrNetIntegration.Config {
  public class SolrServerElement : ConfigurationElement {
    private const string ID = "id";
    private const string URL = "url";
    private const string DOCUMENT_TYPE = "documentType";
    private const string METHOD = WebRequestMethods.Http.Get;
            

    [ConfigurationProperty(ID, IsKey = true, IsRequired = true)]
    public string Id {
      get { return base[ID].ToString(); }
      set { base[ID] = value; }
    }

    [ConfigurationProperty(URL, IsKey = true, IsRequired = true)]
    public string Url {
      get { return base[URL].ToString(); }
      set { base[URL] = value; }
    }

    [ConfigurationProperty(DOCUMENT_TYPE, IsKey = true, IsRequired = true)]
    public string DocumentType {
      get { return base[DOCUMENT_TYPE].ToString(); }
      set { base[DOCUMENT_TYPE] = value; }
    }

    [ConfigurationProperty(METHOD, IsKey = true, IsRequired = false)]
    public string HttpMethod {
        get { return base[METHOD].ToString(); }
        set { base[METHOD] = value; }
    }

    public override string ToString() {
      return string.Format("Id: {0} Url: {1} DocType: {2} Method: {3}", Id, Url, DocumentType, HttpMethod);
    }
  }
}