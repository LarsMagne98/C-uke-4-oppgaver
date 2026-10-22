# Notater

- TODO: Hva skjer med selve listen?
  Listene er separate, men objektene de viser til er de samme.

- TODO: Hva skjer med objektene i listen?
  copy[0].Name = "" endrer da det delte objektet som både vault og copy ser,
  mens copy.RemoveAt(0) sletter copy sin referanse til objektet.
