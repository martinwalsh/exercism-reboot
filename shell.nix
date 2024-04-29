{ pkgs ? import <nixpkgs> { } }:
pkgs.mkShell {
  packages = with pkgs; [
    exercism
    clojure
    leiningen
    dotnet-sdk_8
    bats
    cmake
    crystal_1_8
    elixir_1_16
    gleam
    erlang # for gleam
    rebar3 # for gleam

    # # Build gnu-cobol for darwin
    # (gnu-cobol.overrideAttrs (
    #   oldAttrs: {
    #     buildInputs = oldAttrs.buildInputs ++ [ libxml2 ];
    #     preConfigure = ''
    #       export XML_CFLAGS="-I${pkgs.libxml2.dev}/include/libxml2"
    #       export XML_LIBS="-L${pkgs.libxml2.out}/lib -lxml2"
    #     '';
    #   }
    # ))
  ];
}
