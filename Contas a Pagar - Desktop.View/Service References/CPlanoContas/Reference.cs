﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contas_a_Pagar___Desktop.View.CPlanoContas
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PlanoContas", Namespace = "http://schemas.datacontract.org/2004/07/Contas_a_Pagar___Desktop.Model", IsReference = true)]
    [System.SerializableAttribute()]
    public partial class PlanoContas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ConsolidacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Consolidacao
        {
            get
            {
                return this.ConsolidacaoField;
            }
            set
            {
                if ((this.ConsolidacaoField.Equals(value) != true))
                {
                    this.ConsolidacaoField = value;
                    this.RaisePropertyChanged("Consolidacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Conta
        {
            get
            {
                return this.ContaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ContaField, value) != true))
                {
                    this.ContaField = value;
                    this.RaisePropertyChanged("Conta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CPlanoContas.ICPlanoContas")]
    public interface ICPlanoContas
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/Inserir", ReplyAction = "http://tempuri.org/ICPlanoContas/InserirResponse")]
        string Inserir(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/Inserir", ReplyAction = "http://tempuri.org/ICPlanoContas/InserirResponse")]
        System.Threading.Tasks.Task<string> InserirAsync(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/Alterar", ReplyAction = "http://tempuri.org/ICPlanoContas/AlterarResponse")]
        string Alterar(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/Alterar", ReplyAction = "http://tempuri.org/ICPlanoContas/AlterarResponse")]
        System.Threading.Tasks.Task<string> AlterarAsync(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/Excluir", ReplyAction = "http://tempuri.org/ICPlanoContas/ExcluirResponse")]
        string Excluir(string Conta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/Excluir", ReplyAction = "http://tempuri.org/ICPlanoContas/ExcluirResponse")]
        System.Threading.Tasks.Task<string> ExcluirAsync(string Conta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/SelecionarTodos", ReplyAction = "http://tempuri.org/ICPlanoContas/SelecionarTodosResponse")]
        Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[] SelecionarTodos();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/SelecionarTodos", ReplyAction = "http://tempuri.org/ICPlanoContas/SelecionarTodosResponse")]
        System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[]> SelecionarTodosAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/SelecionarTodosCriterio", ReplyAction = "http://tempuri.org/ICPlanoContas/SelecionarTodosCriterioResponse")]
        Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[] SelecionarTodosCriterio(string Criterio, string Escolha);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/SelecionarTodosCriterio", ReplyAction = "http://tempuri.org/ICPlanoContas/SelecionarTodosCriterioResponse")]
        System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[]> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/PlanoContasExiste", ReplyAction = "http://tempuri.org/ICPlanoContas/PlanoContasExisteResponse")]
        bool PlanoContasExiste(string Conta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICPlanoContas/PlanoContasExiste", ReplyAction = "http://tempuri.org/ICPlanoContas/PlanoContasExisteResponse")]
        System.Threading.Tasks.Task<bool> PlanoContasExisteAsync(string Conta);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICPlanoContasChannel : Contas_a_Pagar___Desktop.View.CPlanoContas.ICPlanoContas, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CPlanoContasClient : System.ServiceModel.ClientBase<Contas_a_Pagar___Desktop.View.CPlanoContas.ICPlanoContas>, Contas_a_Pagar___Desktop.View.CPlanoContas.ICPlanoContas
    {
        public CPlanoContasClient()
        {
        }

        public CPlanoContasClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public CPlanoContasClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CPlanoContasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CPlanoContasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public string Inserir(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas)
        {
            return base.Channel.Inserir(oPlanoContas);
        }

        public System.Threading.Tasks.Task<string> InserirAsync(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas)
        {
            return base.Channel.InserirAsync(oPlanoContas);
        }

        public string Alterar(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas)
        {
            return base.Channel.Alterar(oPlanoContas);
        }

        public System.Threading.Tasks.Task<string> AlterarAsync(Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas oPlanoContas)
        {
            return base.Channel.AlterarAsync(oPlanoContas);
        }

        public string Excluir(string Conta)
        {
            return base.Channel.Excluir(Conta);
        }

        public System.Threading.Tasks.Task<string> ExcluirAsync(string Conta)
        {
            return base.Channel.ExcluirAsync(Conta);
        }

        public Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[] SelecionarTodos()
        {
            return base.Channel.SelecionarTodos();
        }

        public System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[]> SelecionarTodosAsync()
        {
            return base.Channel.SelecionarTodosAsync();
        }

        public Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[] SelecionarTodosCriterio(string Criterio, string Escolha)
        {
            return base.Channel.SelecionarTodosCriterio(Criterio, Escolha);
        }

        public System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CPlanoContas.PlanoContas[]> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return base.Channel.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public bool PlanoContasExiste(string Conta)
        {
            return base.Channel.PlanoContasExiste(Conta);
        }

        public System.Threading.Tasks.Task<bool> PlanoContasExisteAsync(string Conta)
        {
            return base.Channel.PlanoContasExisteAsync(Conta);
        }
    }
}