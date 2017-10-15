# Intro:

Pra começar: O que é injeção de dependencia?

 "Hollywood Principle:" Don't Call Us, We'll Call You.


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

Imagine que outras pessoas vão continuar a programar este projetoe queiram implementar uma nova classe de envio. Será neessário, além de implementar a nova classe, também mudar o objeto WorkingRobot para adicionar mais esta dependência. E isto se propagará a cada mudança. Ruim pra caramba. Num modelo mais real, se a a persistência de dados fosse movida para outro SGBD, deveria ser criada nova classe e o objeto WorkingRobot também deveria conhecer a conexão com esta.

Injetando os objetos na classe WorkingRobot na sua criação tiramos a responsabilidade dela de saber como escolher o melhor metodo de envio, ou qual conexão a ser usada no banco de dados, ou qual sgbd a ser usado etc. Ela simplesmente faz o que é do domínio dela.

Para solucionar esse cen�rio, podemos usar alguns tipos de inje��o de depend�ncia.

 Tipos de inje��o:

- Corre��o em cada tipo de inje��o

### Inje��o por construtor.
Quando injetamos por construtor, fazemos que a classe quando instanciada já receba todas as dependências que ela precise. Que a classe que recebe a injeção já "nasça" (seja instanciado) com todos os objetos que ela precisa carregados nela. Assim basta a classe principal saber como trabalhar sobre os objetos que ela tem, não importando como estes já vieram configurados e carregados.
No exemplo abaixo fizemos a classe principal instanciar os objetos necessários e também escolher qual tipo de notificação será enviada. E, voilà, ela funciona exatamento como anterior.


### Inje��o por setter.

Quando injetamos por setter, o objeto dependente possui um atributo que pode receber qualquer instância de um tipo (geralmente uma interface). E durante a execução é setado no objeto dependente a instância da interface desejada. Tendo em vista que o objeto dependente usará apenas métodos da interface, e que por contrato, todas as implementações dessa interface implementarão estes métodos, a classe dependente não precisa se preocupar como será executado o método, apenas o executará.


### Ferramentas de injeção

Não é obrigatório o uso de um container de IoC para usar injeção de dependência, mas o uso deles não garante que você está fazendo de fato injeção. Ao registrar sua dependência em um container, este injetará automaticamente o objeto correspondente (baseado no registro já executado, por isso é interessante o manter no start de sua aplicação).

E as ferramentas? Tem muitas? Pra .Net tem : Ninjector, Spring.NET, autoFac, PicoContainer.NET etc. Leia mais em https://www.hanselman.com/blog/ListOfNETDependencyInjectionContainersIOC.aspx .
Mas é tudo igual? Não. Além de performances diferentes, alguns têm recursos que outros não possuem como controle de ciclo de vida, auto-encaminhamento etc.
Segue uma lista com benchmarks e comparações de features.
http://www.palmmedia.de/blog/2011/8/30/ioc-container-benchmark-performance-comparison


### Tempo de vida de uma injeção

Transient - Uma nova instância do componente será criada a cada solicitação no container. Se múltiplas solicitações orem feitas, cada solicitante terá sua própria instância. Estas instâncias não são geridas pelo container, ele não as destruirá no dispose, esta será uma responsabilidade do caller.

Singleton - Existirá no máximo uma instância do serviço registrado e o container manterá esta até ser disposado. Todos os clientes receberão a mesma instância do container.

Scoped - Similar ao transiente, porém este tem tempo de vida limitado e o objeto será destruído junto ao seu escopo.


# Resultados

- Comparativo de antes e depois (mostrar as vantagens que foram enunciadas)

# Conclus�es

- Use essa porra!!


Bibliografia:

http://www.javacreed.com/why-should-we-use-dependency-injection/

https://www.codeproject.com/Tips/657668/Dependency-Injection-DI

http://www.devx.com/dotnet/Article/34066

https://richnewman.wordpress.com/about/code-listings-and-diagrams/dependency-injection-examples/dependency-injection-example-interface-injection/

https://msdn.microsoft.com/en-us/library/dn178469(v=pandp.30).aspx

https://stackoverflow.com/questions/4596300/where-exactly-is-the-difference-between-ioc-and-di

http://simpleinjector.readthedocs.io/en

http://www.ninject.org/wiki.html
