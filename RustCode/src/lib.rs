#[no_mangle]
pub extern "C" fn add(v1: u32, v2: u32) -> u32 {
    println!("Hello, from Rust!");
    v1 + v2
}