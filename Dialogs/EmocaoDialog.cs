using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace Emocoes.Dialogs
{

    [Serializable]
    [LuisModel("fe371861-ea39-4607-92f9-7140623d0e7f", "9c4abd102784456a9e431a0748509c95")] // primeiro argumento  subscritos  2 argumento é a versao 
    public class EmocaoDialog : LuisDialog<object>
    {


            [LuisIntent("Sobre")] //Sobre
            public async Task Sobre(IDialogContext context, LuisResult result)
            { // passando em paramentro o dialogo com IDial



                await context.PostAsync($"Eu sou um bot estou sempre aprendendo tenha paciencia comigo ");



            }

        
            [LuisIntent("None")]
            public async Task None(IDialogContext context, LuisResult result)
            { // passando em paramentro o dialogo com IDial



                await context.PostAsync($"Desculpe, não consegui entender a frase {result.Query}");



            }
            [LuisIntent("Complemento")]//Complimento
            public async Task Complemento(IDialogContext context, LuisResult result)
            { // passando em paramentro o dialogo com IDial



                await context.PostAsync($"Ola eu sou um bot  e posso ajudar você em que precisar  ok ");



            }
            //[LuisIntent("Cotacao")]
            //public async Task Cotacao(IDialogContext context, LuisResult result)
            //{ // passando em paramentro o dialogo com IDial

            //    var moedas = result.Entities?.Select(e => e.Entity); // estou pegando todas as entidades que o luis reconheceu 

            //    await context.PostAsync($"Eu farei uma cotacao para moedas {string.Join(",",moedas.ToArray())}");



            //}
            [LuisIntent("Consciência")]//Complimento
            public async Task Consiencia(IDialogContext context, LuisResult result)
            { // passando em paramentro o dialogo com IDial



                await context.PostAsync($"Ola eu sou um bot  de emocões");



            }

   

    }
}