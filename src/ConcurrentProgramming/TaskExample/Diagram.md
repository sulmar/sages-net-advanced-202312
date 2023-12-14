~~~ mermaid
graph TD
  A[Created] -->|Start| B[WaitingToRun]
  B -->|Start| C[Running]
  C -->|Completion| D[RanToCompletion]
  C -->|Faulted| E[Faulted]
  C -->|Canceled| F[Canceled]
  D -->|ContinueWith| G[ContinuationScheduled]
  G -->|Start| H[ContinuationRunning]
  H -->|Completion| I[ContinuationRanToCompletion]
  H -->|Faulted| J[ContinuationFaulted]
  H -->|Canceled| K[ContinuationCanceled]
~~~ 