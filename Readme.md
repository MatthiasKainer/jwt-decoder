# jwt decoder

A very simple json web token decoder for the cli. No verification, only meant for debugging horribly long JWTs somewhat more controlled.

## Build

```bash
# run
make run
# build for linux
make build-linux 
# build for windows
make build-win
```

## Usage

Returns the parts of the JWT on separate lines, with signature header on line with index 0, and payload on line with index 1

Example

```bash
> echo "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWV9.dyt0CoTl4WoVjAHI9Q_CwSKhl6d_9rhM3NrXuJttkao" | jwt-cli
{"alg":"HS256","typ":"JWT"}
{"sub":"1234567890","name":"John Doe","admin":true}
```

From there you can process it further, ie

```bash
> echo "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWV9.dyt0CoTl4WoVjAHI9Q_CwSKhl6d_9rhM3NrXuJttkao" | jwt-cli | sed -n '2p' | jq ".name"
"John Doe"
```