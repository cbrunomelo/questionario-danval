a -

INSERT INTO Pessoas(Nome, Idade, EnderecoID)
VALUES('Brunce Wayne', 74, 65);

b -
 UPDATE Pessoas
 SET Idade=20
 WHERE PessoaID=123;

c -
SELECT Pessoas.Nome, Pessoas.Idade, Enderecos.Rua, Enderecos.Numero, Enderecos.Cidade, Enderecos.Estado, Enderecos.Pais
FROM Pessoas
INNER JOIN Enderecos ON Pessoas.EnderecoID = Enderecos.ID
WHERE PessoaID = 123;
