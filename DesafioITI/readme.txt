Basta rodar o projeto no visual studio ou similar.

Caso a pagina inicial do swagger não abra cole a Url abaixo no navegador.
https://localhost:5001/swagger/index.html

A aplicação possui apenas 1 endpoint e serve exclusivamente para validação da senha.
rote /api/Auth/PasswordValidation

analisando o problema pensei em uma esteira de regras, utilizei Regex para cada uma das validações.
não domino regex mas é algo que se encontra em abundância na internet, e como tenho muito pouco tempo livre atualmente
pensei em aproveitar o que existe por aí.
caso exista ao menos um item com false eu já rejeito a senha, todos os critérios devem ser respeitados.

pensei em esteira visto que em uma evolução cada criterio pode ter uma mensagem especifica idependente 
de um outro.
Ex:caso a senha atendesse a todos os critério mas não tivesse no minimo 9 caracteres eu poderia lançar
uma mensagem tratada(A senha deve conter no minimo 9 caracteres);

a responsabilidade de validar se a senha é valida ou não ficou a cargo do próprio dominio
eu criei uma camada CrossCutting que foi onde implementei a esteira e fiz a chamada de dentro da camada de dominio
injetando a inteface por método.



