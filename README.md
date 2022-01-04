# BsonPath

Bson 的 JsonPath 路徑選擇器

reference: https://github.com/json-path/JsonPath

## To-dos
### Operators
- [X] ```$```   The root element to query. This starts all path expressions.
- [ ] ```@```   The current node being processed by a filter predicate.
- [ ] ```*```   Wildcard. Available anywhere a name or numeric are required.
- [ ] ```..```  Deep scan. Available anywhere a name is required.
- [X] ```.<name>``` Dot-notated child
- [ ] ```['<name>' (, '<name>')]``` 	Bracket-notated child or children
- [ ] ```[<number> (, <number>)]``` 	Array index or indexes
- [ ] ```[start:end]``` 	Array slice operator
- [ ] ```[?(<expression>)]``` 	Filter expression. Expression must evaluate to a boolean value.

### Functions

### Filter Operators
