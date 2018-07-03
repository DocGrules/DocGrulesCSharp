# DocGrules_oficial
>>>Grupo 08: Registro de Presença de Alunos<<<

>>>Integrantes: Josias Amorim de Souza, Wevisky Martins Silveira e Fábio<<<

>>>Processo de desenvolvimento:<<<
Foi utilizado o Visual Studio 2017 para desenvolver a aplicação em desktop junto com a linguagem C# o sistema de presença de alunos, 
onde será exibido a tela do login e a senha, após visualizará a tela de registro de chamada, onde contém 3 campos: eventos, consulta 
de matrícula e CPF.

>>>Processo de execução:<<<
Como é um sistema para registrar presença, o mesmo recebe do SOAP todos os eventos salvos dentro do banco de dados, onde será exibido
pelo Combobox, e ao selecionar o evento permite e habilita a consulta da matrícula do aluno, onde o SOAP retorna, se a matrícula
consta no banco de dados ou não, ao retornar verdadeiro o sistema permite a pesquisa do CPF, assim retornando CPF válido será 
permitido o registro do aluno com o evento.
A consulta do CPF é feita em outra aplicação do C# que é o validador de CPF, assim validando o sistema habilitará o botão salvar 
para que seja enviado para SOAP o evento e a matrícula do aluno.  

>>>Experiência durante a organização do trabalho:<<<
Junto com toda equipe pude aprender mais sobre a linguagem C# e consequentimente outras aplicações dentro do Visual Studio, 
foi de grande importancia pois tivemos novas experiencia para toda nossa vida desde a troca de ideias como também no desenvolvimento 
e também envolvimento de outras aplicações que se comunicam entre si. Todos os integrantes estiveram juntos, acompanhando e ajudando 
no desenvolvimento de toda aplicação, e não poderia deixar de informar a grande importancia do Alison do 5° período SI que deu uma moral 
grande para que nosso sistema funcionasse com sua aplicação, e também ao Tayrone que ajudou sobre comitar no GIT. Nossa maior dificuldade 
foi fazer com que o sistema funcionasse buscando informação do SOAP, mas quando trabalhamos em equipe tudo flui e funciona muito bem. 


