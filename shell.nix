{ pkgs ? import <nixpkgs> { } }:
pkgs.mkShell {
  packages = with pkgs; [
    exercism
    clojure
    leiningen
    dotnet-sdk_8
    bats
    cmake
  ];

  inputsFrom = [ ];
}
