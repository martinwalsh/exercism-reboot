{ pkgs ? import <nixpkgs> { } }:
pkgs.mkShell {
  packages = with pkgs; [
    exercism
  ];

  inputsFrom = [ ];
}
