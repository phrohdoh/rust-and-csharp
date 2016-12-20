# `rust-and-csharp`

An experiment in Rust<->C# FFI.

## LICENSE

MIT

## Compiling

### Rust

You will need to target `i686-apple-darwin` on macOS so add that target via rustup.

`rustup target add i686-apple-darwin`

Then run `cargo build --target i686-apple-darwin` to compile.

### CSharp

`xbuild CSharpCode/CSharpCode.sln` (or `msbuild`) will compile the executable.

## Running

1) Copy/move the resulting library from `RustCode/target/i686-apple-darwin/debug/libcsharp_interop_test.dylib` to `CSharpCode/CSharpCode/bin/Debug/`

2) From within the above-noted `Debug/` directory: `mono --debug CSharpCode.exe`
