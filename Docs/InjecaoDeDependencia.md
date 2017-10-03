# Intro:

Pra come�ar: O que � inje��o de depend�ncia?
Na vida pr�tica: Voc� precisa ir ao mercado. Para executar esta tarefa suas depend�ncias s�o:
 - Verificar se h� �gua no carburador do carro suficiente para o trajeto;
 - Verificar num mapa o trajeto mais curto;
 - Ouvir na r�dio local se h� algum impedimento no caminho;
 - Montar a lista de compras;
Ent�o a� voc� j� pode ir comprar em seguran�a. A inje��o de depend�ncia ocorre quando:
 - Seu carro lhe avisa se h� alguma pend�ncia (�gua, g�s etc) e n�o � necess�rio que voc� saiba como medir;
 - Seu GPS j� lhe tra�a o melhor caminho se baseando no mapa e no tr�nsito;
 - Algu�m que te ama muito j� fez essa lista e deixou em cima da mesa prontinha. (Case com essa pessoa)
 
 Agora falando tecnicamente: O que � inje��o de depend�ncia?
A Inje��o de Depend�ncia � um paradigma que permite um objeto n�o ser respons�vel pela cria��o ou manuten��o de outros que fa�am parte da sua lista de depend�ncias. 
O objeto recebe (� injetado nele) os demais objetos que s�o necess�rios � ele para executar sua tarefa.
A inje��o de depend�ncias � ferramenta para conquistar melhorias de c�digo como: Desacopla��o de classe, reutiliza��o de c�digo, possibilita teste correto, manter a responsabilidade �nica da classe etc.


# Na pr�tica. 

- Cen�rio ruim em C#

Neste c�digo existe � claro que a classe Worker depende de Database, Database, MailNotification, PidgeonNotification. Qualquer modifica��o no contrato destas classes exige uma modifica��o na classe worker.
Tamb�m � muito ruim testar este c�digo. No teste voc� obrigatoriamente teria que escrever o arquivo, salvar no banco e at� mandar um e-mail para que seu processo chegue ao fim.

Para solucionar esse cen�rio, podemos usar alguns tipos de inje��o de depend�ncia.

 Tipos de inje��o:

- Corre��o em cada tipo de inje��o

### Inje��o no construtor.

### Inje��o de Interface no construtor.

### Inje��o por set.



# Resultados

- Comparativo de antes e depois (mostrar as vantagens que foram enunciadas)

# Conclus�es

- Use essa porra!!


Bibliografia:

http://www.javacreed.com/why-should-we-use-dependency-injection/

https://www.codeproject.com/Tips/657668/Dependency-Injection-DI

http://www.devx.com/dotnet/Article/34066