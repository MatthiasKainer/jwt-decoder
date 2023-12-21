clean:
	rm -rf bin
	rm -rf obj

run:
	dotnet run

build-linux:
	dotnet publish -c Release -o bin jwt-decoder.fsproj
	@echo 
	@echo 
	@echo "Add jwt-decoder to the path by running the following line:"
	@echo
	@echo '  [[ ":$$PATH:" != *":$(PWD)/bin"* ]] && PATH="$${PATH}:$(PWD)/bin"'

build-win:
	dotnet publish -r win-x64 -c Release -o bin jwt-decoder.fsproj
	@echo 
	@echo 
	@echo "Add jwt-decoder to the path by running the following line:"
	@echo
	@echo '  [[ ":$$PATH:" != *":$(PWD)/bin"* ]] && PATH="$${PATH}:$(PWD)/bin"'