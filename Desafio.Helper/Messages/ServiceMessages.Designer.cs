﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desafio.Helper.Messages {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ServiceMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ServiceMessages() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Desafio.Helper.Messages.ServiceMessages", typeof(ServiceMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a A tarefa &apos;{tarefa}&apos; ja` existe na lista de tarefas.
        /// </summary>
        public static string ExistentRegister {
            get {
                return ResourceManager.GetString("ExistentRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Opa! O campo &quot;{0}&quot; está inválido. Confira-o novamente..
        /// </summary>
        public static string InvalidInput {
            get {
                return ResourceManager.GetString("InvalidInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Opa! O campo &apos;{0}&apos; deve possuir no máximo {1} caracteres..
        /// </summary>
        public static string MaxInputSize {
            get {
                return ResourceManager.GetString("MaxInputSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Opa! O campo &apos;{0}&apos; deve possuir no mínimo {1} caractere(s)..
        /// </summary>
        public static string MinInputSize {
            get {
                return ResourceManager.GetString("MinInputSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Vish... o resgitro &apos;{0}&apos; não foi encontrado (X_X).
        /// </summary>
        public static string RegisterNotFound {
            get {
                return ResourceManager.GetString("RegisterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Opa! O registro &apos;{0}&apos; foi removido!  \(⌒▽⌒)/.
        /// </summary>
        public static string RemovedRegister {
            get {
                return ResourceManager.GetString("RemovedRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Calma! Não está esquecendo de nada? O campo &apos;{0}&apos; é obrigatório!.
        /// </summary>
        public static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Opa! A operação &apos;{0}&apos; foi realizada com sucesso! \(⌒▽⌒)/.
        /// </summary>
        public static string SuccessfulOperation {
            get {
                return ResourceManager.GetString("SuccessfulOperation", resourceCulture);
            }
        }
    }
}
