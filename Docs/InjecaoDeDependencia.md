# Intro:

Pra começar: O que é injeção de dependência?
Na vida prática: Você precisa ir ao mercado. Para executar esta tarefa suas dependências são:
 - Verificar se há água no carburador do carro suficiente para o trajeto;
 - Verificar num mapa o trajeto mais curto;
 - Ouvir na rádio local se há algum impedimento no caminho;
 - Montar a lista de compras;
Então aí você já pode ir comprar em segurança. A injeção de dependência ocorre quando:
 - Seu carro lhe avisa se há alguma pendência (água, gás etc) e não é necessário que você saiba como medir;
 - Seu GPS já lhe traça o melhor caminho se baseando no mapa e no trânsito;
 - Alguém que te ama muito já fez essa lista e deixou em cima da mesa prontinha. (Case com essa pessoa)
 
 Agora falando tecnicamente: O que é injeção de dependência?
A Injeção de Dependência é um paradigma que permite um objeto não ser responsável pela criação ou manutenção de outros que façam parte da sua lista de dependências. 
O objeto recebe (é injetado nele) os demais objetos que são necessários à ele para executar sua tarefa.
A injeção de dependências é ferramenta para conquistar melhorias de código como: Desacoplação de classe, reutilização de código, possibilita teste correto, manter a responsabilidade única da classe etc.


# Na prática. 

- Cenário ruim em C#

Neste código existe é claro que a classe Worker depende de Database, Database, MailNotification, PidgeonNotification. Qualquer modificação no contrato destas classes exige uma modificação na classe worker.
Também é muito ruim testar este código. No teste você obrigatoriamente teria que escrever o arquivo, salvar no banco e até mandar um e-mail para que seu processo chegue ao fim.

Para solucionar esse cenário, podemos usar alguns tipos de injeção de dependência.

 Tipos de injeção:

- Correção em cada tipo de injeção

### Injeção no construtor.

### Injeção de Interface no construtor.

### Injeção por set.



# Resultados

- Comparativo de antes e depois (mostrar as vantagens que foram enunciadas)

# Conclusões

- Use essa porra!!


Bibliografia:

http://www.javacreed.com/why-should-we-use-dependency-injection/

https://www.codeproject.com/Tips/657668/Dependency-Injection-DI

http://www.devx.com/dotnet/Article/34066