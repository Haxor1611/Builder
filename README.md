# Builder
I AM AWARE THAT THIS TOOL COULD BE USED AS A TYPE OF MALWARE. THIS IS STRICTLY EDUCATIONAL PURPOSES ONLY.

>Usage
```CSharp
binary.Write("/*/" + settings);
```
You can also add your own 'prefix'
```CSharp
string stubSettings = Encoding.ASCII.GetString(stubBytes).Substring(Encoding.ASCII.GetString(stubBytes).IndexOf("/*/")).Replace("/*/", "");
```
Replace the '/*/' with whatever
```CSharp
binary.Write("/*/" + settings);
```
Just make sure to replace it here too. Otherwise it cant read and write to it.


>This can be used to also edit existing exes.

------------


### I plan on adding more features like: 

- Reading and writing to existing exe files.
- Adding functions to the stub.
- Making the stub be created inside of the builder instead of an existing one.
